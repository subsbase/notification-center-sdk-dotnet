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
    
    public Task<CreateSubjectResult> CreateSubjectAsync(CreateSubjectRequest subject)
    {
        return ApiClient.PostAsync<CreateSubjectResult>(Path, subject);
    }

    public Task<UpdateSubjectResult> UpdateSubjectAsync(UpdateSubjectRequest subject)
    {
        return ApiClient.PutAsync<UpdateSubjectResult>(Path, subject);
    }
}