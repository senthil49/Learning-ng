using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using To_Do.Model;

namespace To_Do.Controller
{
    public class TaskController :ApiController
    {
        public IHttpActionResult GetTasks()
        {

            var db = new TasksDb();


            //var model = new List<Task>
            //{
            //    new Task() { Id = 1, Description = "Order lunch", DueDate = DateTime.Now, Status = false},
            //    new Task() { Id = 1, Description = "MOT", DueDate = DateTime.Now, Status = false},
            //    new Task() { Id = 1, Description = "PSM Certification", DueDate = DateTime.Now, Status = false},
            //    new Task() { Id = 1, Description = "Buy brother Anniversary gift", DueDate = DateTime.Now, Status = false},
            //    new Task() { Id = 1, Description = "buy xmas jumpers!", DueDate = DateTime.Now, Status = false}
            //};

            return Ok(db.Tasks);
        }

    }
}