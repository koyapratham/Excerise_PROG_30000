using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;
using API.Persistance;

namespace Excerise_PROG_30000.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private Database _database;
        public ProfessorController(Database database)
        {
            _database = database;
        }

        [HttpPost]
        public IActionResult CreateProfessor (Professor professor)
        {
            _database.Professors.Add(professor);
            _database.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfessor(string id){
        var reponse = await _database.Professors.FindAsync(new Guid(id));
        if (reponse == null)
        return NotFound();  

        return Ok(reponse);

        }

       
        


    }
}