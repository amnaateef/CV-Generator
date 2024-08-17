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
    public partial class WorkForm : Form
    {
        private CVData cvData;

        List<TextBox> workTextBoxes = new List<TextBox>();

        public WorkForm(CVData cvData)
        {
            InitializeComponent();
            this.cvData = cvData ?? new CVData();
        }

        private void btn_addWork_Click(object sender, EventArgs e)
        {
            Label labelWadd = new Label();
            labelWadd.AutoSize = true;
            labelWadd.Name = "labelWadd";
            labelWadd.Size = new System.Drawing.Size(32, 16);
            labelWadd.Text = "Organization";
            TextBox txt_work = new TextBox();
            txt_work.Size = new System.Drawing.Size(424, 22);

            Label labelWDesadd = new Label();
            labelWDesadd.AutoSize = true;
            labelWDesadd.Name = "labelWDesadd";
            labelWDesadd.Size = new System.Drawing.Size(32, 16);
            labelWDesadd.Text = "Experience";
            TextBox txt_workDes = new TextBox();
            txt_workDes.Size = new System.Drawing.Size(424, 22);

            workTextBoxes.Add(txt_work);
            workTextBoxes.Add(txt_workDes);

            fp_work.Controls.Add(labelWadd);
            fp_work.Controls.Add(txt_work);
            fp_work.Controls.Add(labelWDesadd);
            fp_work.Controls.Add(txt_workDes);
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
            cvData.Work.WorkPlaces = new List<string>();
            cvData.Work.WorkDeses = new List<string>();

            workTextBoxes.Add(txt_work);
            workTextBoxes.Add(txt_workDes);

            // Loop through all TextBox controls in the workTextBoxes list
            for (int i = 0; i < workTextBoxes.Count; i += 2)
            {
                cvData.Work.WorkPlaces.Add(workTextBoxes[i].Text);
                cvData.Work.WorkDeses.Add(workTextBoxes[i + 1].Text);
            }

            var form2 = new Form2(cvData);
            form2.Show();

            this.Hide();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["SkillForm"].Show();
        }

        private void WorkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
