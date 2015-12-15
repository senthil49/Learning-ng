using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_Do.Model
{
    public class Task
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool Status { get; set; }
    }
}