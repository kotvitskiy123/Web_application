﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }
        public List<ObjectiveTag> ObjectiveTags { get; set; }

        public Tag()
        {
            ObjectiveTags = new List<ObjectiveTag>();
        }
    }
}
