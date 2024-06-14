using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using WinFormsAppEmployee.Data;
using WinFormsAppEmployee.DataEmployee;
using WinFormsAppEmployee.Model;

namespace WinFormsAppEmployee.Forms
{
    public partial class FormGetEmployee : Form
    {
        WorkingDataEmployeeGet workingDataEmployeeGet;
        DataTable dataTable;
        public FormGetEmployee()
        {
            InitializeComponent();
            string _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;
            workingDataEmployeeGet = new WorkingDataEmployeeGet(_connectionString);
            List<Persons> persons = workingDataEmployeeGet.GetAllPersons();
            List<Deps> departments = workingDataEmployeeGet.GetAllDeps();
            List<Posts> posts = workingDataEmployeeGet.GetAllPosts();
            List<Status> statuses = workingDataEmployeeGet.GetAllStatuses();

            dataTable = workingDataEmployeeGet.CombinDataEmployee(persons, departments, posts, statuses);
            dataGridViewDataEmployee.DataSource = dataTable;

        }

        private void comboBoxFiltrEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputFiltr = comboBoxFiltrEmployee.Text;
            labelFiltr.Visible = true;
            textBoxFiltr.Visible = true;
            labelFiltr.Text = $"Введите {inputFiltr.ToLower()} для фильтрации.";

        }

        private void buttonApplyFiltr_Click(object sender, EventArgs e)
        {
            string filtrValueComboBox = comboBoxFiltrEmployee.SelectedItem.ToString();
            string filtrValueTextBox = textBoxFiltr.Text.ToLower();


            if (string.IsNullOrEmpty(filtrValueTextBox))
            {
                dataTable.DefaultView.RowFilter = null;
                MessageBox.Show("Неверный фильтр!");
                return;
            }


            string selectFiltrColum = String.Empty;
            if (filtrValueComboBox.Equals("Статусу"))
            {
                selectFiltrColum = "Статус";
            }
            else if (filtrValueComboBox.Equals("Отделу"))
            {
                selectFiltrColum = "Отдел";

            }
            else if (filtrValueComboBox.Equals("Должности"))
            {
                selectFiltrColum = "Должность";

            }
            else if (filtrValueComboBox.Equals("Фамилии"))
            {
                selectFiltrColum = "Фамилия";

            }

            if (!string.IsNullOrEmpty(selectFiltrColum))
            {
                dataTable.DefaultView.RowFilter = $"{selectFiltrColum} LIKE '%{filtrValueTextBox}%'";
                if (dataTable.DefaultView.Count == 0)
                {
                    dataTable.DefaultView.RowFilter = null;
                    MessageBox.Show("В БД него не найдено по фильтру.");

                }
            }
            else
            {
                MessageBox.Show("Неверный данные для фильра");

            }
        }
    }
}
