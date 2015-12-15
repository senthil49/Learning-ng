using System.Collections.Generic;

using To_Do.Model;

namespace To_Do.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<To_Do.Model.TasksDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(To_Do.Model.TasksDb context)
        {
            if (!context.Tasks.Any())
            {
                context.Tasks.AddRange(
                    new List<Task>()
                        {
                            new Task() { Id = 1, Description = "Order lunch", DueDate = DateTime.Now, Status = false},
                            new Task() { Id = 1, Description = "MOT", DueDate = DateTime.Now, Status = false},
                            new Task() { Id = 1, Description = "PSM Certification", DueDate = DateTime.Now, Status = false},
                            new Task() { Id = 1, Description = "Buy brother Anniversary gift", DueDate = DateTime.Now, Status = false},
                            new Task() { Id = 1, Description = "buy xmas jumpers!", DueDate = DateTime.Now, Status = false}
                        });
            }
        }
    }
}
