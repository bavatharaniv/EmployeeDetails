using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTraining.Models
{
    public class Softlock
    {
        
        public int EmployeeId { get; set; }
        public string Manager { get; set; }
        public DateTime Reqdate { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        [Key]
        public int LockId { get; set; }
        public string RequestMessage { get; set; }
        public string WFMRemark { get; set; }
        public string ManagerStatus { get; set; }
        public string MGRStatusComments { get; set; }
        public DateTime MgrLastUpdate { get; set; }

        public Employees Employee { get; set; }
    }
}
