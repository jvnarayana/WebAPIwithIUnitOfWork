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

        public void Add(Project entity)
        {
            try
            {
                _appilicationDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        public IEnumerable<Project> GetProjects()
        {
            return _appilicationDBContext.projects.ToList();

        }

        public Project GetById(int id)
        {
            return _appilicationDBContext.projects.Where(x => x.ProjectId == id).FirstOrDefault();
        }

    }
}

