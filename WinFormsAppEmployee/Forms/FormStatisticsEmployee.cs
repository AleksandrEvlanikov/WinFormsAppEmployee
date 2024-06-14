using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppEmployee.DataEmployee;
using WinFormsAppEmployee.Model;

namespace WinFormsAppEmployee.Forms
{
    public partial class FormStatisticsEmployee : Form
    {
        WorkingDataEmployeeGet workingDataEmployeeGet;
        DataTable dataTable;
        List<Persons> persons;
        List<Status> statuses;
        public FormStatisticsEmployee()
        {
            InitializeComponent();
            string _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;
            workingDataEmployeeGet = new WorkingDataEmployeeGet(_connectionString);
            persons = workingDataEmployeeGet.GetAllPersons();
            List<Deps> departments = workingDataEmployeeGet.GetAllDeps();
            List<Posts> posts = workingDataEmployeeGet.GetAllPosts();
            statuses = workingDataEmployeeGet.GetAllStatuses();

            dataTable = workingDataEmployeeGet.CombinDataEmployee(persons, departments, posts, statuses);

            comboBoxStatus.DataSource = statuses;
            comboBoxStatus.DisplayMember = "Name";
        }

        private void buttonPullStatistics_Click(object sender, EventArgs e)
        {
            if (!radioButtonEmployed.Checked && !radioButtonUnemployed.Checked)
            {
                MessageBox.Show("Выберите кого хотите вывести(Принятые или уволеных)");
                return;
            }

            dataGridViewStatistics.Visible = true;
            string valueComboBoxStatistics = comboBoxStatus.Text;
            if (string.IsNullOrEmpty(valueComboBoxStatistics))
            {
                MessageBox.Show("Выберите статус из списка");
                return;
            }

            var dateFrom = dateTimePickerFrom.Value;
            var dateTo = dateTimePickerTo.Value;
            bool acceptedOrFired = radioButtonEmployed.Checked;

            var statisticsEmployee = workingDataEmployeeGet.StatisticsDataEmployee(dataTable, valueComboBoxStatistics, dateFrom, dateTo, acceptedOrFired);
            
            dataGridViewStatistics.DataSource = statisticsEmployee;
            dataGridViewStatistics.Visible = true;
        }
    }
}
