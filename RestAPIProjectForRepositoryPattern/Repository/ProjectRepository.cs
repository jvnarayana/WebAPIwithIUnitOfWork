using System;
using System.Collections.Generic;
using System.Linq;
using RestAPIProjectForRepositoryPattern.DBAccess;
using RestAPIProjectForRepositoryPattern.Entities;
using RestAPIProjectForRepositoryPattern.Models;

namespace RestAPIProjectForRepositoryPattern.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly AppilicationDBContext _appilicationDBContext;

        public ProjectRepository(AppilicationDBContext appilicationDBContext) : base(appilicationDBContext)
        {
            _appilicationDBContext = appilicationDBContext;
        }

        public void Add(Project project)
        {
            try
            {
                _appilicationDBContext.Set<Project>().Add(project);
               
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        public IEnumerable<Project> GetProjects()
        {
            return _appilicationDBContext.Set<Project>().ToList();

        }

        public Project GetById(int id)
        {
            return _appilicationDBContext.Set<Project>().Find(id);
        }

    }
}

