using System;
using RestAPIProjectForRepositoryPattern.DBAccess;

namespace RestAPIProjectForRepositoryPattern.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppilicationDBContext _appilicationDBContext;
        private readonly IDeveloperRepository _developerRepository;
        public readonly IProjectRepository _projectRepository;

        public UnitOfWork(AppilicationDBContext appilicationDBContext )
        {
            _appilicationDBContext = appilicationDBContext;
            _developerRepository = new DeveloperRepository(_appilicationDBContext);
            _projectRepository = new ProjectRepository(_appilicationDBContext);



        }

        
        public IDeveloperRepository developerRepository { get => new DeveloperRepository(_appilicationDBContext); set => new DeveloperRepository(_appilicationDBContext); }
        public IProjectRepository projectRepository { get => new ProjectRepository(_appilicationDBContext); set => new ProjectRepository(_appilicationDBContext); }

        public int completed()
        {
            return _appilicationDBContext.SaveChanges();
        }

        public void Dispose()
        {
            _appilicationDBContext.Dispose();
        }
    }
}


