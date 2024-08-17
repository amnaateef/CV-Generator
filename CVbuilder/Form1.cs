using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace CVbuilder
{
    public partial class Form1 : Form
    {
        private CVData cvData;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
           
        }

        public void CreatePdfCV(string name, string gender, string dob, string address, List<string> skills, List<string> skillDescriptions, 
        List<string> edus, List<string> eduDescriptions, List<string> works, List<string> workDescriptions, List<string> quals, List<string> qualDescriptions, List<string> hobbies, List<string> hobbyDescriptions)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addSkill_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addEdu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addWork_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addQual_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addHobby_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            var infoForm = new InfoForm(cvData);
            infoForm.Show();

            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
