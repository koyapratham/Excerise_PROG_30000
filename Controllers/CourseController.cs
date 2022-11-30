using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace Excerise_PROG_30000.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private DataContext _database;
        public CourseController(DataContext database)
        {
            _database = database;
        }

        [HttpPost]
        public IActionResult CreateProfessor (IEnumerable<Professor> professors)
        {
            
        }
    }
}