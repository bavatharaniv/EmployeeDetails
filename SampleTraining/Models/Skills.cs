using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleTraining.Models
{
    public class Skills
    {
        [Key]
        public int SkillId { get; set; }
        public string Name { get; set; }
        public ICollection<Skillmap> SkillMaps { get; set; }

    }
}
