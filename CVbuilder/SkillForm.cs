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
    public partial class SkillForm : Form
    {
        private CVData cvData;

        List<TextBox> skillsTextBoxes = new List<TextBox>();
        List<TextBox> hobbiesTextBoxes = new List<TextBox>();

        public SkillForm(CVData cvData)
        {
            InitializeComponent();
            this.cvData = cvData ?? new CVData();
        }

        private void btn_addSkill_Click(object sender, EventArgs e)
        {
            Label labelSadd = new Label();
            labelSadd.AutoSize = true;
            labelSadd.Name = "labelSadd";
            labelSadd.Size = new System.Drawing.Size(32, 16);
            labelSadd.Text = "Skills";
            TextBox txt_skill = new TextBox();
            txt_skill.Size = new System.Drawing.Size(424, 22);

            Label labelSDesadd = new Label();
            labelSDesadd.AutoSize = true;
            labelSDesadd.Name = "labelSadd";
            labelSDesadd.Size = new System.Drawing.Size(32, 16);
            labelSDesadd.Text = "Description";
            TextBox txt_skillDes = new TextBox();
            txt_skillDes.Size = new System.Drawing.Size(424, 22);

            skillsTextBoxes.Add(txt_skill);
            skillsTextBoxes.Add(txt_skillDes);

            fp_skill.Controls.Add(labelSadd);
            fp_skill.Controls.Add(txt_skill);
            fp_skill.Controls.Add(labelSDesadd);
            fp_skill.Controls.Add(txt_skillDes);
        }

        private void btn_addHobby_Click(object sender, EventArgs e)
        {
            Label labelHadd = new Label();
            labelHadd.AutoSize = true;
            labelHadd.Name = "labelEadd";
            labelHadd.Size = new System.Drawing.Size(32, 16);
            labelHadd.Text = "Hobby";
            TextBox txt_Hobby = new TextBox();
            txt_Hobby.Size = new System.Drawing.Size(424, 22);

            Label labelHDesadd = new Label();
            labelHDesadd.AutoSize = true;
            labelHDesadd.Name = "labelEDesadd";
            labelHDesadd.Size = new System.Drawing.Size(32, 16);
            labelHDesadd.Text = "Description";
            TextBox txt_HobbyDes = new TextBox();
            txt_HobbyDes.Size = new System.Drawing.Size(424, 22);

            hobbiesTextBoxes.Add(txt_Hobby);
            hobbiesTextBoxes.Add(txt_HobbyDes);

            fp_hobby.Controls.Add(labelHadd);
            fp_hobby.Controls.Add(txt_Hobby);
            fp_hobby.Controls.Add(labelHDesadd);
            fp_hobby.Controls.Add(txt_HobbyDes);
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

            Form nextForm = Application.OpenForms["WorkForm"];
            if (nextForm != null)
            {
                // If the form is already open, show it
                nextForm.Show();
            }
            else
            {
                // If the form is not open, create a new instance and show it
                nextForm = new WorkForm(cvData);
                nextForm.Show();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["EduForm"].Show();
        }

        private void SkillForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cvData.Skills.SkillsList = new List<string>();
            cvData.Skills.SkillDeses = new List<string>();
            cvData.Skills.Hobbies = new List<string>();
            cvData.Skills.HobbyDeses = new List<string>();

            skillsTextBoxes.Add(txt_skill);
            skillsTextBoxes.Add(txt_skillDes);

            hobbiesTextBoxes.Add(txt_Hobby);
            hobbiesTextBoxes.Add(txt_HobbyDes);

            // Loop through all TextBox controls in the skillsTextBoxes list
            for (int i = 0; i < skillsTextBoxes.Count; i += 2)
            {
                cvData.Skills.SkillsList.Add(skillsTextBoxes[i].Text);
                cvData.Skills.SkillDeses.Add(skillsTextBoxes[i + 1].Text);
            }

            // Loop through all TextBox controls in the hobbiesTextBoxes list
            for (int i = 0; i < hobbiesTextBoxes.Count; i += 2)
            {
                cvData.Skills.Hobbies.Add(hobbiesTextBoxes[i].Text);
                cvData.Skills.HobbyDeses.Add(hobbiesTextBoxes[i + 1].Text);
            }
        }
    }
}
