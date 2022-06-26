using System;
using System.Collections.Generic;
using RestAPIProjectForRepositoryPattern.Entities;
using RestAPIProjectForRepositoryPattern.Models;

namespace RestAPIProjectForRepositoryPattern.Repository
{
    public interface IDeveloperRepository: IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
