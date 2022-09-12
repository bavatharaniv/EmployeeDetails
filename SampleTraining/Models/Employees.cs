using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTraining.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public char EmpName { get; set; }
        public char Status { get; set; }
        public char Manager { get; set; }
        public char Wfmanager { get; set; }
        public string Email { get; set; }
        public string Lockstatus { get; set; }
        public int Experience { get; set; }
        public int ProfileId { get; set; }

        public ICollection<Softlock> softlocks { get; set; }
        public ICollection<Skillmap> skillMaps { get; set; }

    }
}
