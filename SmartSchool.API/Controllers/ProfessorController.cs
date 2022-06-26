using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System.Linq;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professors);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context.Professors.FirstOrDefault(p => p.Id == id);
            if(professor == null) return BadRequest("No professor found with that id");
            return Ok(professor);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _context.Professors.FirstOrDefault(p => p.Nome.Contains(nome));
            if (professor == null) return BadRequest("No professor found with that name");
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor) 
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Professor professor, int id) 
        {
            var prof = _context.Professors.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (prof == null) return BadRequest("No professor found with that id");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(Professor professor, int id) 
        {
            var prof = _context.Professors.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if(prof == null) return BadRequest("Professor not found");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var professor = _context.Professors.FirstOrDefault(p => p.Id == id);
            if (professor == null) return BadRequest("No professor found with that id");
            _context.Remove(professor);
            _context.SaveChanges();
            return Ok();
        }
    }
}
