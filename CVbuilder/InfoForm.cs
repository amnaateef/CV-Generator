using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVbuilder
{
    public partial class InfoForm : Form
    {
        private CVData cvData;

        public InfoForm(CVData cvData)
        {
            InitializeComponent();
            this.cvData = cvData ?? new CVData();
        }

        private void btn_next_Click(object sender, EventArgs e)
        { 
            this.Hide();

            Form nextForm = Application.OpenForms["EduForm"];
            if (nextForm != null)
            {
                // If the form is already open, show it
                nextForm.Show();
            }
            else
            {
                // If the form is not open, create a new instance and show it
                nextForm = new EduForm(cvData);
                nextForm.Show();
            }
        }

        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_name.Text) &&
            !string.IsNullOrEmpty(genderBox.Text) &&
            !string.IsNullOrEmpty(txt_address.Text))
            {
                cvData.GeneralInfo = new GeneralInfo
                {
                    Name = txt_name.Text,
                    Gender = genderBox.Text,
                    Dob = dobPicker.Text,
                    Address = txt_address.Text
                };
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
