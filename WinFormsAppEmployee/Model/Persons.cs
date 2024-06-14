using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEmployee.Model
{
    internal class Persons
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime DateEmploy { get; set; }
        public DateTime? DateUneploy { get; set; }
        public int IdStatus { get; set; }
        public int IdDepartment { get; set; }
        public int IdPosition { get; set; }
    }
}
