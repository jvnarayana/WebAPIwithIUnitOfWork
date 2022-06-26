using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPIProjectForRepositoryPattern.DBAccess;
using RestAPIProjectForRepositoryPattern.Entities;
using RestAPIProjectForRepositoryPattern.Repository;

namespace RestAPIProjectForRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public ProjectController(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        // GET: api/Project
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Getprojects()
        {
            return _unitOfWork.projectRepository.GetAll().ToList();
        }

        // GET: api/Project/5
        [HttpGet("{id}")]
        public ActionResult<Project> GetProject(int id)
        {
            var project = _unitOfWork.projectRepository.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return project;
        }

        //// PUT: api/Project/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProject(int id, Project project)
        //{
        //    if (id != project.ProjectId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(project).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProjectExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Project
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Project> PostProject(Project project)
        {
            try
            {
                _unitOfWork.projectRepository.Add(project);
                _unitOfWork.completed();

            }
            catch (Exception ex)
            {
                ex.ToString();

            }

            return CreatedAtAction("GetProject", new { id = project.ProjectId }, project);
        }

        //// DELETE: api/Project/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Project>> DeleteProject(int id)
        //{
        //    var project = await _context.projects.FindAsync(id);
        //    if (project == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.projects.Remove(project);
        //    await _context.SaveChangesAsync();

        //    return project;
        //}

        //private bool ProjectExists(int id)
        //{
        //    return _context.projects.Any(e => e.ProjectId == id);
        //}
    }
}
