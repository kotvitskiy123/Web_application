using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Entities
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime timeOfRealizing { get; set; }
        public bool IsCompleted { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<ObjectiveTag> ObjectiveTags { get; set; }

        public Objective()
        {
            ObjectiveTags = new List<ObjectiveTag>();
        }
    }
}
