using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using To_Do.Model;

namespace To_Do.Services
{
   public interface IDataService
   {
       Response<To_Do.Model.Task> GetTasks();

       Response<string> AddTask(int Id);

       Response<string> DeleteTask(int id);
   }
}
