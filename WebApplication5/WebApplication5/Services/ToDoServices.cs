using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.ModelsDto;

namespace WebApplication5.Services
{
    public class ToDoServices
    {

        public object GetTodos(ObjectivesContext db)
        {

            return db.Objectives
                .Include(x => x.Category)
                .Include(x => x.ObjectiveTags)
                .Select(x => new ObjectiveDto
                {
                    Deadline = x.timeOfRealizing,
                    Category = x.Category.Name,
                    Tags = x.ObjectiveTags.Select(t => t.Tag.Name).ToList(),
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                    IsCompleted = x.IsCompleted
                }).ToList();
        }
    }
}
