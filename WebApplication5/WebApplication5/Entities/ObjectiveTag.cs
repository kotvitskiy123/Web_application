using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Entities
{
    public class ObjectiveTag
    {
        public int ObjectiveId { get; set; }
        public Objective Objective { get; set; }

        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
