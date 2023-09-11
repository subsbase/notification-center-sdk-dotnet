using Microsoft.Extensions.Logging;
using NotificationCenterSdk.Extentsions;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

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
        SetRealmHeader();
    }

    public Task<TResponse> GetAsync<TResponse>(string path, bool requireAuth = true, Dictionary<string, string>? headers = null)
    {
        return ProcessRequestAsync<TResponse>(
            HttpMethod.Get,
            path,
            null,
            requireAuth,
            headers);
    }

    public Task<TResponse> PostAsync<TResponse>(string path, object body, TResponse response, bool requireAuth = true, Dictionary<string, string>? headers = null)
    {
        return ProcessRequestAsync<TResponse>(
            HttpMethod.Post,
            path,
            body,
            requireAuth,
            headers);
    }

    public Task<TResponse> PostAsync<TResponse>(string path, object body, bool requireAuth = true, Dictionary<string, string>? headers = null)
    {
        return ProcessRequestAsync<TResponse>(
            HttpMethod.Post,
            path,
            body,
            requireAuth,
            headers);
    }

    public Task<TResponse> PutAsync<TResponse>(string path, object body, bool requireAuth = true, Dictionary<string, string>? headers = null)
    {
        return ProcessRequestAsync<TResponse>(HttpMethod.Put,
            path,
            body,
            requireAuth,
            headers);
    }


    public Task<TResponse> PatchAsync<TResponse>(string path, object body, bool requireAuth = true, Dictionary<string, string>? headers = null)
    {
        return ProcessRequestAsync<TResponse>(HttpMethod.Patch,
            path,
            body,
            requireAuth,
            headers);
    }

    private async Task<TResponse> ProcessRequestAsync<TResponse>(HttpMethod httpMethod, string path, object body, bool requireAuth, Dictionary<string, string>? headers)
    {
        var response = await SendRequestAsync(
            httpMethod,
            path,
            body,
            requireAuth,
            headers);

        await ValidateResponseAsync(response);

        return response.Content.Headers.ContentLength > 0 ? await response.Content.ReadFromJsonAsync<TResponse>(new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        }) : Activator.CreateInstance<TResponse>();
    }

    private async Task<HttpResponseMessage> SendRequestAsync(
        HttpMethod httpMethod,
        string path,
        object requestBody,
        bool requireAuth,
        Dictionary<string, string>? headers)
    {
        string? accessToken = _httpClient.DefaultRequestHeaders.Authorization?.Parameter;

        if (requireAuth && !IsValidAccessToken(accessToken))
        {
            await ResetAccessTokenAsync();
        }

        return await SendAsync(httpMethod, path, requestBody, headers);
    }

    private Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string path, object requestBody, Dictionary<string, string>? headers)
    {
        string json = JsonSerializer.Serialize(requestBody);
        HttpContent httpContent = new StringContent(json, Encoding.UTF8, ContentType);

        var httpRequest = new HttpRequestMessage(httpMethod, path) { Content = httpContent };

        foreach (var kvp in headers.OrEmptyIfNull())
        {
            httpRequest.Headers.Add(kvp.Key, kvp.Value);
        }

        _logger.LogInformation("{HttpMethod}: {Path} \n\tBody: {json}", httpMethod, path, json);
        return _httpClient.SendAsync(httpRequest);
    }

    private async Task ResetAccessTokenAsync()
    {
        _logger.LogInformation("Resetting access_token...");
        var responseMessage = await SendAsync(HttpMethod.Post, "auth", new { apiSecret = _credentials.ApiSecret }, new Dictionary<string, string>
        {
            { "x-realm", _credentials.Realm }
        });

        var response = await responseMessage.Content.ReadFromJsonAsync<AuthenticationResponse>();

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", response.AccessToken);
    }

    private void SetRealmHeader()
    {
        _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-realm", _credentials.Realm);
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

        return expires > DateTime.UtcNow;
    }

    private async Task ValidateResponseAsync(HttpResponseMessage httpResponse)
    {
        if (!httpResponse.IsSuccessStatusCode)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(await httpResponse.Content.ReadAsStringAsync());
            Console.ForegroundColor = defaultColor;
        }
        httpResponse.EnsureSuccessStatusCode();
    }

    private class AuthenticationResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}