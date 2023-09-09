namespace NotificationCenterSdk.Subjects;

public interface ISubjectsClient
{
    Task<IEnumerable<Subject>> ListSubjectsAsync(ListSubjectsRequest request);
    Task<CreateSubjectResult> CreateSubjectAsync(Subject subject);
    Task<UpdateSubjectResult> UpdateSubjectAsync(Subject subject);
}