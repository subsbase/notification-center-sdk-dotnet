namespace NotificationCenterSdk.Subjects;

public interface ISubjectsClient
{
    Task<IEnumerable<Subject>> ListSubjectsAsync(ListSubjectsRequest request);
    Task<CreateSubjectResponse> CreateSubjectAsync(Subject subject);
    Task<UpdateSubjectResponse> UpdateSubjectAsync(Subject subject);
}