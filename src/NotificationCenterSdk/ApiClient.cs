using Microsoft.Extensions.Logging;
using NotificationCenterSdk.Extentsions;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Net.Http.Json;

namespace NotificationCenterSdk;

public class ApiClient : IApiClient
{
    private const string ContentType = "application/json";

    private readonly HttpClient _httpClient;
    private readonly NotificationCenterCredentials _credentials;
    private readonly ILogger _logger;

    public ApiClient(HttpClient httpClient, NotificationCenterCredentials credentials, ILogger<ApiClient> logger)
    {
        _httpClient = httpClient;
        _credentials = credentials;
        _logger = logger;
    }

    public async Task<TResponse> GetAsync<TResponse>(string path, IDictionary<string, string>? headers = null)
    {
        HttpResponseMessage response = await SendRequestAsync(
            HttpMethod.Get,
            path,
            null,
            headers);

        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<TResponse> PostAsync<TResponse>(string path, object body, TResponse response, IDictionary<string, string>? headers = null)
    {
        HttpResponseMessage httpResponse = await SendRequestAsync(
            HttpMethod.Post,
            path,
            body,
            headers);

        ValidateResponse(httpResponse);

        return await httpResponse.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<TResponse> PostAsync<TResponse>(string path, object body, IDictionary<string, string>? headers = null)
    {
        HttpResponseMessage response = await SendRequestAsync(
            HttpMethod.Post,
            path,
            body,
            headers);

        ValidateResponse(response);

        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<TResponse> PutAsync<TResponse>(string path, object body, IDictionary<string, string>? headers = null)
    {
        HttpResponseMessage response = await SendRequestAsync(
            HttpMethod.Put,
            path,
            body,
            headers);

        ValidateResponse(response);

        return await response.Content.ReadFromJsonAsync<TResponse>();
    }


    public async Task<TResponse> PatchAsync<TResponse>(string path, object body, IDictionary<string, string>? headers = null)
    {
        HttpResponseMessage response = await SendRequestAsync(
            HttpMethod.Patch,
            path,
            body,
            headers);

        ValidateResponse(response);

        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    private async Task<HttpResponseMessage> SendRequestAsync(
        HttpMethod httpMethod,
        string path,
        object requestBody,
        IDictionary<string, string>? headers)
    {
        string accessToken = _httpClient.DefaultRequestHeaders.Authorization.Parameter;

        if (IsValidAccessToken(accessToken))
        {
            await ResetAccessTokenAsync();
        }

        string json = JsonSerializer.Serialize(requestBody);
        HttpContent httpContent = new StringContent(json, Encoding.UTF8, ContentType);

        var httpRequest = new HttpRequestMessage(httpMethod, path) { Content = httpContent };

        foreach (var kvp in headers.OrEmptyIfNull())
        {
            httpRequest.Headers.Add(kvp.Key, kvp.Value);
        }

        _logger.LogInformation("{HttpMethod}: {Path} \n\tBody: {json}", httpMethod, path, json);
        return await _httpClient.SendAsync(httpRequest);
    }

    private async Task ResetAccessTokenAsync()
    {
        _logger.LogInformation("Resetting access_token...");
        var response = await PostAsync("/auth", _credentials, new { access_token = "" });

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", response.access_token);
    }

    private bool IsValidAccessToken(string accessToken)
    {
        if (string.IsNullOrWhiteSpace(accessToken))
        {
            return false;
        }
        var tokenHandler = new JwtSecurityTokenHandler();
        var jwtToken = tokenHandler.ReadJwtToken(accessToken);
        var expires = jwtToken.ValidTo;

        return expires < DateTime.UtcNow;
    }

    private void ValidateResponse(HttpResponseMessage httpResponse)
    {
        httpResponse.EnsureSuccessStatusCode();
    }
}