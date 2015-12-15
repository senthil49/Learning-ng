using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using Dapper;

using To_Do.Model;

namespace To_Do.Services
{
    public class DataService : IDataService
    {
        public Response<Task> GetTasks()
        {
            SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TasksDb"].ToString());
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();

            var query = "select Description from dbo.Tasks";

            var test = _connection.Query<string>(query);
            


            return null;
        }

        public Response<string> AddTask(int Id)
        {
            return null;
        }

        public Response<string> DeleteTask(int id)
        {
            return null;
        }
    }
}