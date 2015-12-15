using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace To_Do.Model
{
    public class TasksDb : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

    }
}