using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInformationUI : Form
    {

        public StudentInformationUI()
        {
            InitializeComponent();
        }
        Student anStudent= new Student();
        private void showButton_Click(object sender, EventArgs e)
        {
            anStudent.regNo =   regNoTextBox.Text;
            anStudent.firstName = firstNameTextBox.Text;
            anStudent.lastName = lastNameTextBox.Text;

            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;

            MessageBox.Show(anStudent.firstName +" "+ anStudent.lastName +" your registration no is : " + anStudent.regNo);
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = anStudent.regNo;
            firstNameTextBox.Text = anStudent.firstName;
            lastNameTextBox.Text = anStudent.lastName;
        }
    }
}
