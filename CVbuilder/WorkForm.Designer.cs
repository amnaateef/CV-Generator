namespace CVbuilder
{
    partial class WorkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fp_work = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_work = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_workDes = new System.Windows.Forms.TextBox();
            this.btn_addWork = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.fp_work.SuspendLayout();
            this.SuspendLayout();
            // 
            // fp_work
            // 
            this.fp_work.AutoScroll = true;
            this.fp_work.Controls.Add(this.label15);
            this.fp_work.Controls.Add(this.txt_work);
            this.fp_work.Controls.Add(this.label16);
            this.fp_work.Controls.Add(this.txt_workDes);
            this.fp_work.Controls.Add(this.btn_addWork);
            this.fp_work.Font = new System.Drawing.Font("SF UI  Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_work.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fp_work.Location = new System.Drawing.Point(88, 170);
            this.fp_work.Name = "fp_work";
            this.fp_work.Size = new System.Drawing.Size(524, 129);
            this.fp_work.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Organization";
            // 
            // txt_work
            // 
            this.txt_work.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_work.Location = new System.Drawing.Point(3, 19);
            this.txt_work.Name = "txt_work";
            this.txt_work.Size = new System.Drawing.Size(496, 23);
            this.txt_work.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(3, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Experience";
            // 
            // txt_workDes
            // 
            this.txt_workDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_workDes.Location = new System.Drawing.Point(3, 64);
            this.txt_workDes.Name = "txt_workDes";
            this.txt_workDes.Size = new System.Drawing.Size(496, 23);
            this.txt_workDes.TabIndex = 30;
            // 
            // btn_addWork
            // 
            this.btn_addWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addWork.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addWork.Location = new System.Drawing.Point(3, 93);
            this.btn_addWork.Name = "btn_addWork";
            this.btn_addWork.Size = new System.Drawing.Size(66, 24);
            this.btn_addWork.TabIndex = 29;
            this.btn_addWork.Text = "Add";
            this.btn_addWork.UseVisualStyleBackColor = true;
            this.btn_addWork.Click += new System.EventHandler(this.btn_addWork_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF UI Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(311, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 39);
            this.label6.TabIndex = 39;
            this.label6.Text = "Work";
            // 
            // btn_prev
            // 
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Font = new System.Drawing.Font("SF UI  Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_prev.Location = new System.Drawing.Point(392, 416);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(96, 40);
            this.btn_prev.TabIndex = 46;
            this.btn_prev.Text = "◀ Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("SF UI  Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_next.Location = new System.Drawing.Point(494, 416);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(150, 40);
            this.btn_next.TabIndex = 45;
            this.btn_next.Text = "Save and Generate ▶";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.fp_work);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkForm_FormClosing);
            this.fp_work.ResumeLayout(false);
            this.fp_work.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fp_work;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_work;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_workDes;
        private System.Windows.Forms.Button btn_addWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
    }
}