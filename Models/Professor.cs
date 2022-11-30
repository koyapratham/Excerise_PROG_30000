using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Professor
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public bool isFullTime { get; set; }
        public List<Course> courses  { get; set; }
    }
}