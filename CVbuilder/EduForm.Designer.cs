namespace CVbuilder
{
    partial class EduForm
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
            this.fp_edu = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_edu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_eduDes = new System.Windows.Forms.TextBox();
            this.btn_addEdu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fp_qual = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Qual = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_QualDes = new System.Windows.Forms.TextBox();
            this.btn_addQual = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.fp_edu.SuspendLayout();
            this.fp_qual.SuspendLayout();
            this.SuspendLayout();
            // 
            // fp_edu
            // 
            this.fp_edu.AutoScroll = true;
            this.fp_edu.Controls.Add(this.label13);
            this.fp_edu.Controls.Add(this.txt_edu);
            this.fp_edu.Controls.Add(this.label14);
            this.fp_edu.Controls.Add(this.txt_eduDes);
            this.fp_edu.Controls.Add(this.btn_addEdu);
            this.fp_edu.Font = new System.Drawing.Font("SF UI  Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_edu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fp_edu.Location = new System.Drawing.Point(101, 75);
            this.fp_edu.Name = "fp_edu";
            this.fp_edu.Size = new System.Drawing.Size(524, 129);
            this.fp_edu.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Institute";
            // 
            // txt_edu
            // 
            this.txt_edu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_edu.Location = new System.Drawing.Point(3, 19);
            this.txt_edu.Name = "txt_edu";
            this.txt_edu.Size = new System.Drawing.Size(496, 23);
            this.txt_edu.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(3, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Grade";
            // 
            // txt_eduDes
            // 
            this.txt_eduDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_eduDes.Location = new System.Drawing.Point(3, 64);
            this.txt_eduDes.Name = "txt_eduDes";
            this.txt_eduDes.Size = new System.Drawing.Size(496, 23);
            this.txt_eduDes.TabIndex = 28;
            // 
            // btn_addEdu
            // 
            this.btn_addEdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fp_edu.SetFlowBreak(this.btn_addEdu, true);
            this.btn_addEdu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addEdu.Location = new System.Drawing.Point(3, 93);
            this.btn_addEdu.Name = "btn_addEdu";
            this.btn_addEdu.Size = new System.Drawing.Size(66, 24);
            this.btn_addEdu.TabIndex = 28;
            this.btn_addEdu.Text = "Add";
            this.btn_addEdu.UseVisualStyleBackColor = true;
            this.btn_addEdu.Click += new System.EventHandler(this.btn_addEdu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF UI Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(280, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 39);
            this.label5.TabIndex = 38;
            this.label5.Text = "Education";
            // 
            // fp_qual
            // 
            this.fp_qual.AutoScroll = true;
            this.fp_qual.Controls.Add(this.label17);
            this.fp_qual.Controls.Add(this.txt_Qual);
            this.fp_qual.Controls.Add(this.label18);
            this.fp_qual.Controls.Add(this.txt_QualDes);
            this.fp_qual.Controls.Add(this.btn_addQual);
            this.fp_qual.Font = new System.Drawing.Font("SF UI  Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_qual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fp_qual.Location = new System.Drawing.Point(101, 272);
            this.fp_qual.Name = "fp_qual";
            this.fp_qual.Size = new System.Drawing.Size(524, 129);
            this.fp_qual.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Qualification";
            // 
            // txt_Qual
            // 
            this.txt_Qual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Qual.Location = new System.Drawing.Point(3, 19);
            this.txt_Qual.Name = "txt_Qual";
            this.txt_Qual.Size = new System.Drawing.Size(496, 23);
            this.txt_Qual.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(3, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Description";
            // 
            // txt_QualDes
            // 
            this.txt_QualDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_QualDes.Location = new System.Drawing.Point(3, 64);
            this.txt_QualDes.Name = "txt_QualDes";
            this.txt_QualDes.Size = new System.Drawing.Size(496, 23);
            this.txt_QualDes.TabIndex = 32;
            // 
            // btn_addQual
            // 
            this.btn_addQual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addQual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addQual.Location = new System.Drawing.Point(3, 93);
            this.btn_addQual.Name = "btn_addQual";
            this.btn_addQual.Size = new System.Drawing.Size(66, 24);
            this.btn_addQual.TabIndex = 31;
            this.btn_addQual.Text = "Add";
            this.btn_addQual.UseVisualStyleBackColor = true;
            this.btn_addQual.Click += new System.EventHandler(this.btn_addQual_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF UI Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(261, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 39);
            this.label7.TabIndex = 40;
            this.label7.Text = "Qualifications";
            // 
            // btn_prev
            // 
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_prev.Location = new System.Drawing.Point(370, 407);
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
            this.btn_next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_next.Location = new System.Drawing.Point(573, 407);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(96, 40);
            this.btn_next.TabIndex = 45;
            this.btn_next.Text = "Next ▶";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(472, 407);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 40);
            this.btn_save.TabIndex = 47;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // EduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.fp_qual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fp_edu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "EduForm";
            this.Text = "EduForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EduForm_FormClosing);
            this.fp_edu.ResumeLayout(false);
            this.fp_edu.PerformLayout();
            this.fp_qual.ResumeLayout(false);
            this.fp_qual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fp_edu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_edu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_eduDes;
        private System.Windows.Forms.Button btn_addEdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel fp_qual;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Qual;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_QualDes;
        private System.Windows.Forms.Button btn_addQual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_save;
    }
}