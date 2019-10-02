using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.ModelsDto
{
    public class ObjectiveDto
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
    }
}
