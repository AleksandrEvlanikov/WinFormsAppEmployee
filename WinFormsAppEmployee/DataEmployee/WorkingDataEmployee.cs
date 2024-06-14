using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppEmployee.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsAppEmployee.Data
{
    internal class WorkingDataEmployee
    {
        private string _connectionString;

        public WorkingDataEmployee(string connectionString)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;
        }



        public void InsertDep(string name)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.deps (name) VALUES (@Name)", connection);
                sqlCommand.Parameters.AddWithValue("@Name", name);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertStatus(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.status (name) VALUES (@Name)", connection);
                sqlCommand.Parameters.AddWithValue("@Name", name);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertPosts(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.posts (name) VALUES (@Name)", connection);
                sqlCommand.Parameters.AddWithValue("@Name", name);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertPerson(Persons persons)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.persons (first_name, second_name, last_name, date_employ, date_uneploy, status, id_dep, id_post) VALUES (@FirstName, @SecondName, @LastName, @DateEmploy, @DateUneploy, @Status, @IdDep, @IdPost)", connection);
                sqlCommand.Parameters.AddWithValue("@FirstName", persons.FirstName);
                sqlCommand.Parameters.AddWithValue("@SecondName", persons.SecondName);
                sqlCommand.Parameters.AddWithValue("@LastName", persons.LastName);
                sqlCommand.Parameters.AddWithValue("@DateEmploy", persons.DateEmploy);
                sqlCommand.Parameters.AddWithValue("@DateUneploy", (object)persons.DateUneploy ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@Status", persons.IdStatus);
                sqlCommand.Parameters.AddWithValue("@IdDep", persons.IdDepartment);
                sqlCommand.Parameters.AddWithValue("@IdPost", persons.IdPosition);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
