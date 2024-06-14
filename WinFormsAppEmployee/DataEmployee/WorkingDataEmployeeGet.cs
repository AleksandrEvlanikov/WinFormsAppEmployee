using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppEmployee.Model;

namespace WinFormsAppEmployee.DataEmployee
{
    internal class WorkingDataEmployeeGet
    {
        private string _connectionString;

        public WorkingDataEmployeeGet(string connectionString)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;
        }


        public List<Persons> GetAllPersons()
        {
            List<Persons> persons = new List<Persons>();

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM persons", connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    persons.Add(new Persons
                    {
                        Id = (int)reader["id"],
                        FirstName = reader["first_name"].ToString(),
                        SecondName = reader["second_name"].ToString(),
                        LastName = reader["last_name"].ToString(),
                        DateEmploy = (DateTime)reader["date_employ"],
                        DateUneploy = reader["date_uneploy"] as DateTime?,
                        IdStatus = (int)reader["status"],
                        IdDepartment = (int)reader["id_dep"],
                        IdPosition = (int)reader["id_post"]
                    });
                } 
            }
            return persons;
        }


        public List<Deps> GetAllDeps()
        {
            List<Deps> departments = new List<Deps>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM deps", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    departments.Add(new Deps
                    {
                        Id = (int)reader["id"],
                        Name = reader["name"].ToString()
                    });
                }
            }
            return departments;
        }

        public List<Posts> GetAllPosts()
        {
            List<Posts> posts = new List<Posts>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM posts", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    posts.Add(new Posts
                    {
                        Id = (int)reader["id"],
                        Name = reader["name"].ToString()
                    });
                }
            }
            return posts;
        }

        public List<Status> GetAllStatuses()
        {
            List<Status> statuses = new List<Status>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM status", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    statuses.Add(new Status
                    {
                        Id = (int)reader["id"],
                        Name = reader["name"].ToString()
                    });
                }
            }
            return statuses;
        }


        public DataTable CombinDataEmployee(List<Persons> persons, List<Deps> deps, List<Posts> posts, List<Status> statuses)
        {
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("Фамилия");
            dataTable.Columns.Add("Имя");
            dataTable.Columns.Add("Отчество");
            dataTable.Columns.Add("Статус");
            dataTable.Columns.Add("Отдел");
            dataTable.Columns.Add("Должность");
            dataTable.Columns.Add("Дата устройства", typeof(DateTime));
            dataTable.Columns.Add("Дата увольнения", typeof (DateTime));


            foreach(var person in persons)
            {
                var status = statuses.FirstOrDefault(x => x.Id == person.IdStatus)?.Name;
                var deportman = deps.FirstOrDefault(x => x.Id == person.IdDepartment)?.Name;
                var position = posts.FirstOrDefault(x => x.Id == person.IdPosition)?.Name;

                dataTable.Rows.Add(
                    person.FirstName,
                    person.SecondName,
                    person.LastName,
                    status,
                    deportman,
                    position,
                    person.DateEmploy,
                    person.DateUneploy);
            }

            return dataTable;
        }

        public DataTable StatisticsDataEmployee(DataTable dataTable, string status, DateTime dateFrom, DateTime dateTo, bool acceptedOrFired)
        {
            DataTable statisticsTable = new DataTable();

            statisticsTable.Columns.Add("Дата", typeof (DateTime));
            statisticsTable.Columns.Add("Колличество сотрудников", typeof(int));

            var filteredRows = dataTable.AsEnumerable().Where(x => x.Field<string>("Статус") == status &&
            (acceptedOrFired ? x.Field<DateTime>("Дата устройства") >= dateFrom && x.Field<DateTime>("Дата устройства") <= dateTo
                             : x.Field<DateTime?>("Дата увольнения") >= dateFrom && x.Field<DateTime?>("Дата увольнения") <= dateTo));

            var groupedRows = filteredRows.GroupBy(x => acceptedOrFired ? x.Field<DateTime>("Дата устройства").Date : x.Field<DateTime?>("Дата увольнения").Value.Date)
            .Select(x => new { Date = x.Key, Count = x.Count() });


            foreach (var group in groupedRows)
            {
                statisticsTable.Rows.Add(group.Date, group.Count);
            }
            return statisticsTable;
        }
    }
}
