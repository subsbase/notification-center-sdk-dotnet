namespace NotificationCenterSdk.Subjects;

public interface ISubjectsClient
{
    Task<IEnumerable<Subject>> ListSubjectsAsync(int pageIndex, int pageLimit);
    Task<CreateSubjectResult> CreateSubjectAsync(CreateSubjectRequest subject);
    Task<UpdateSubjectResult> UpdateSubjectAsync(UpdateSubjectRequest subject);
}