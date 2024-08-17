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

namespace CVbuilder
{
    public partial class EduForm : Form
    {
        private CVData cvData;

        List<TextBox> educationTextBoxes = new List<TextBox>();
        List<TextBox> qualificationsTextBoxes = new List<TextBox>();

        public EduForm(CVData cvData)
        {
            InitializeComponent();
            this.cvData = cvData ?? new CVData();
        }

        private void btn_addEdu_Click(object sender, EventArgs e)
        {
            Label labelEadd = new Label();
            labelEadd.AutoSize = true;
            labelEadd.Name = "labelEadd";
            labelEadd.Size = new System.Drawing.Size(32, 16);
            labelEadd.Text = "Institute";
            TextBox txt_edu = new TextBox();
            txt_edu.Size = new System.Drawing.Size(424, 22);
            txt_edu.Name = "txt_edu" + educationTextBoxes.Count;

            Label labelEDesadd = new Label();
            labelEDesadd.AutoSize = true;
            labelEDesadd.Name = "labelEDesadd";
            labelEDesadd.Size = new System.Drawing.Size(32, 16);
            labelEDesadd.Text = "Grade";
            TextBox txt_eduDes = new TextBox();
            txt_eduDes.Size = new System.Drawing.Size(424, 22);
            txt_eduDes.Name = "txt_eduDes" + educationTextBoxes.Count;

            educationTextBoxes.Add(txt_edu);
            educationTextBoxes.Add(txt_eduDes);

            fp_edu.Controls.Add(labelEadd);
            fp_edu.Controls.Add(txt_edu);
            fp_edu.Controls.Add(labelEDesadd);
            fp_edu.Controls.Add(txt_eduDes);
        }

        private void btn_addQual_Click(object sender, EventArgs e)
        {
            Label labelQadd = new Label();
            labelQadd.AutoSize = true;
            labelQadd.Name = "labelEadd";
            labelQadd.Size = new System.Drawing.Size(32, 16);
            labelQadd.Text = "Qualification";
            TextBox txt_Qual = new TextBox();
            txt_Qual.Size = new System.Drawing.Size(424, 22);
            txt_Qual.Name = "txt_eduDes" + educationTextBoxes.Count;

            Label labelQDesadd = new Label();
            labelQDesadd.AutoSize = true;
            labelQDesadd.Name = "labelEDesadd";
            labelQDesadd.Size = new System.Drawing.Size(32, 16);
            labelQDesadd.Text = "Description";
            TextBox txt_QualDes = new TextBox();
            txt_QualDes.Size = new System.Drawing.Size(424, 22);
            txt_QualDes.Name = "txt_eduDes" + educationTextBoxes.Count;

            qualificationsTextBoxes.Add(txt_Qual);
            qualificationsTextBoxes.Add(txt_QualDes);

            fp_qual.Controls.Add(labelQadd);
            fp_qual.Controls.Add(txt_Qual);
            fp_qual.Controls.Add(labelQDesadd);
            fp_qual.Controls.Add(txt_QualDes);
        }

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
              .Concat(controls)
              .Where(c => c.GetType() == type);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form nextForm = Application.OpenForms["SkillForm"];
            if (nextForm != null)
            {
                // If the form is already open, show it
                nextForm.Show();
            }
            else
            {
                // If the form is not open, create a new instance and show it
                nextForm = new SkillForm(cvData);
                nextForm.Show();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["InfoForm"].Show();
        }

        private void EduForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cvData.Education.Institutes = new List<string>();
            cvData.Education.EduDeses = new List<string>();
            cvData.Education.Quals = new List<string>();
            cvData.Education.QualDeses = new List<string>();

            educationTextBoxes.Add(txt_edu);
            educationTextBoxes.Add(txt_eduDes);

            qualificationsTextBoxes.Add(txt_Qual);
            qualificationsTextBoxes.Add(txt_QualDes);

            // Loop through all TextBox controls in the educationTextBoxes list
            for (int i = 0; i < educationTextBoxes.Count; i += 2)
            {
                cvData.Education.Institutes.Add(educationTextBoxes[i].Text);
                cvData.Education.EduDeses.Add(educationTextBoxes[i + 1].Text);
            }

            // Loop through all TextBox controls in the qualificationsTextBoxes list
            for (int i = 0; i < qualificationsTextBoxes.Count; i += 2)
            {
                cvData.Education.Quals.Add(qualificationsTextBoxes[i].Text);
                cvData.Education.QualDeses.Add(qualificationsTextBoxes[i + 1].Text);
            }
        }
    }
}
