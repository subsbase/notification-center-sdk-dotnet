namespace NotificationCenterSdk.Subjects;

public class SubjectsClient : BaseClient, ISubjectsClient
{
    public SubjectsClient(IApiClient apiClient)
        :base(apiClient,Constants.SUBJECTS_PATH)
    {
    }

    public Task<IEnumerable<Subject>> ListSubjectsAsync(ListSubjectsRequest request)
    {
        return ApiClient.GetAsync<IEnumerable<Subject>>(Path + $"?pageNum={request.PageNumber}&pageSize={request.PageSize}");
    }
    
    
    public Task<CreateSubjectResult> CreateSubjectAsync(Subject subject)
    {
        return ApiClient.PostAsync<CreateSubjectResult>(Path, subject);
    }

    public Task<UpdateSubjectResult> UpdateSubjectAsync(Subject subject)
    {
        return ApiClient.PutAsync<UpdateSubjectResult>(Path, subject);
    }
}