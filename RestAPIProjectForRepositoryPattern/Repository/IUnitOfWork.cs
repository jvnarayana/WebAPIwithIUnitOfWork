using System;
namespace RestAPIProjectForRepositoryPattern.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        IDeveloperRepository developerRepository { get; set; }
        IProjectRepository projectRepository { get; set; }
        int completed();
    }
}
