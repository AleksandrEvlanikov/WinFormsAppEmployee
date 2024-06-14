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
using WinFormsAppEmployee.Model;

namespace WinFormsAppEmployee.Forms
{
    public partial class FormAddData : Form
    {
        private WorkingDataEmployee workingDataEmployee;
        public FormAddData()
        {
            InitializeComponent();
            string _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;
            workingDataEmployee = new WorkingDataEmployee(_connectionString);
        }

        private void buttonAddDep_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textInput.Visible = true;
            buttonAddInputData.Visible = true;
            label1.Text = "Введите депортамент: ";
        }

        private void buttonAddPosts_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textInput.Visible = true;
            buttonAddInputData.Visible = true;
            label1.Text = "Введите должность: ";
        }

        private void buttonAddStatus_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textInput.Visible = true;
            buttonAddInputData.Visible = true;
            label1.Text = "Введите статус: ";
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textInput.Visible = true;
            buttonAddInputData.Visible = true;
            labelInfoPerson.Visible = true;
            label1.Text = "Введите через пробел информацию о сотруднике: ";
            labelInfoPerson.Text = "Фамилия Имя Отчество ДатаУстройства ДатаУвольнения ИдСтатуса ИдДепортамента ИдДолжности";
        }

        private void buttonAddInputData_Click(object sender, EventArgs e)
        {
            string textLabel = label1.Text;
            string[] splitLabel = textLabel.Split(" ");
            string inputEmployee = textInput.Text;


            if (splitLabel[1].Equals("депортамент:"))
            {
                if (!string.IsNullOrEmpty(inputEmployee))
                {
                    workingDataEmployee.InsertDep(inputEmployee);
                    MessageBox.Show("Отдел успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите название департамента.");
                }
            }
            else if (splitLabel[1].Equals("должность:"))
            {
                if (!string.IsNullOrEmpty(inputEmployee))
                {
                    workingDataEmployee.InsertPosts(inputEmployee);
                    MessageBox.Show("Должность успешно добавлена!");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите название должности.");
                }
            }
            else if (splitLabel[1].Equals("статус:"))
            {
                if (!string.IsNullOrEmpty(inputEmployee))
                {
                    workingDataEmployee.InsertStatus(inputEmployee);
                    MessageBox.Show("Статус успешно добавлена!");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите статус.");
                }
            }
            else
            {
                string[] arrayInput = inputEmployee.Split(" ");
                if (arrayInput.Length == 8)
                {
                    var person = new Persons
                    {
                        FirstName = arrayInput[0],
                        SecondName = arrayInput[1],
                        LastName = arrayInput[2],
                        DateEmploy = DateTime.Parse(arrayInput[3]),
                        DateUneploy = string.IsNullOrEmpty(arrayInput[4]) ? null : DateTime.Parse(arrayInput[4]),
                        IdStatus = int.TryParse(arrayInput[5], out int status) ? status : 0,
                        IdDepartment = int.TryParse(arrayInput[6], out int dep) ? dep : 0,
                        IdPosition = int.TryParse(arrayInput[7], out int post) ? post : 0
                    };
                    workingDataEmployee.InsertPerson(person);
                    MessageBox.Show("Сотрудник успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите верные данные через пробел.");
                }
            }
            
            
        }
    }
}
