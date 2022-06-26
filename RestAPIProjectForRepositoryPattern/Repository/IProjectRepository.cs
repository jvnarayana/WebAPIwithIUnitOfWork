using System;
using System.Collections.Generic;
using RestAPIProjectForRepositoryPattern.Entities;
using RestAPIProjectForRepositoryPattern.Models;

namespace RestAPIProjectForRepositoryPattern.Repository
{
    public interface IProjectRepository:IGenericRepository<Project>
    {
        void  Add(Project entity);
        IEnumerable<Project> GetAll();
        Project GetById(int id);


    }
}
