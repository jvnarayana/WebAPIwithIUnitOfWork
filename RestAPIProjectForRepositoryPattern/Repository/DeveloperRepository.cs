using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RestAPIProjectForRepositoryPattern.DBAccess;
using RestAPIProjectForRepositoryPattern.Entities;
using RestAPIProjectForRepositoryPattern.Models;

namespace RestAPIProjectForRepositoryPattern.Repository
{
    public class DeveloperRepository: GenericRepository<Developer>, IDeveloperRepository
    {
        private readonly AppilicationDBContext _appilicationDBContext;

        public DeveloperRepository(AppilicationDBContext appilicationDBContext):base(appilicationDBContext)
        {
            _appilicationDBContext = appilicationDBContext;
        }

        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _appilicationDBContext.Set<Developer>().Take(count).ToList();
        }
    }
}
