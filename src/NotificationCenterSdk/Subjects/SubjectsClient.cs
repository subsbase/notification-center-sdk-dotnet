namespace NotificationCenterSdk.Subjects;

public class SubjectsClient : BaseClient, ISubjectsClient
{
    public SubjectsClient(IApiClient apiClient)
        :base(apiClient,Constants.SUBJECTS_PATH)
    {
    }

    public Task<IEnumerable<Subject>> ListSubjectsAsync(int pageIndex, int pageLimit)
    {
        return ApiClient.GetAsync<IEnumerable<Subject>>(Path);
    }

    public Task<Subject> GetSubjectByIdAsync(string subjectId)
    {
        return ApiClient.GetAsync<Subject>($"{Path}/{subjectId}");
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