using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTraining.Models
{
    public class Skillmap
    {
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public Employees employee { get; set; }
        public Skills skills { get; set; }
    }
}
