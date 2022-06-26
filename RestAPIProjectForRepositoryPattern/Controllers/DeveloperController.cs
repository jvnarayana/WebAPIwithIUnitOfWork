using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIProjectForRepositoryPattern.Entities;
using RestAPIProjectForRepositoryPattern.Repository;

namespace RestAPIProjectForRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Developer>> GetPopularDevelopers([FromQueryAttribute] int count)
        {
           var result =  _unitOfWork.developerRepository.GetPopularDevelopers(count).ToList();

            if (result.Count > 1)
            {
                return result.ToList();
            }
            else
            {
              throw new Exception();
            }
            
        }
    }
}