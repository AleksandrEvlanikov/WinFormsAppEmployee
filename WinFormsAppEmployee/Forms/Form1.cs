using WinFormsAppEmployee.Data;
using WinFormsAppEmployee.Forms;

namespace WinFormsAppEmployee
{
    public partial class Form1 : Form
    {
        private WorkingDataEmployee workingDataEmployee;
        public Form1()
        {
            InitializeComponent();
            string _connectionString = "Server=DESKTOP-N2472P3;Database=EmployeeDB;Integrated Security=true;TrustServerCertificate=true;Encrypt=False;";
            workingDataEmployee = new WorkingDataEmployee(_connectionString);

        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {

            FormAddData formAddData = new FormAddData();
            formAddData.Show();


        }

        private void buttonGetEmployee_Click(object sender, EventArgs e)
        {
            FormGetEmployee formGetEmployee = new FormGetEmployee();
            formGetEmployee.Show();
        }

        private void buttonStatisticsEmployee_Click(object sender, EventArgs e)
        {
            FormStatisticsEmployee formStatisticsEmployee = new FormStatisticsEmployee();
            formStatisticsEmployee.Show();
        }
    }
}
