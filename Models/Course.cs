using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string title {get; set; }
        public int numberOfCredits {get; set; }
        List<Professor> professors = new List<Professor>();

    }
}