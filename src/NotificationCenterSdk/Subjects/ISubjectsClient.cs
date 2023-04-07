namespace NotificationCenterSdk.Subjects;

public interface ISubjectsClient
{
    Task<IEnumerable<Subject>> ListSubjectsAsync(int pageIndex, int pageLimit);
    Task<Subject> GetSubjectByIdAsync(string subjectId);
    Task<CreateSubjectResult> CreateSubjectAsync(Subject subject);
    Task<UpdateSubjectResult> UpdateSubjectAsync(Subject subject);
}