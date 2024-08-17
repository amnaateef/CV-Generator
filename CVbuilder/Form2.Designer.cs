namespace CVbuilder
{
    partial class Form2
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
            this.btn_generateFormat1 = new System.Windows.Forms.Button();
            this.btn_generateFormat2 = new System.Windows.Forms.Button();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generateFormat1
            // 
            this.btn_generateFormat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateFormat1.Font = new System.Drawing.Font("SF UI  Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateFormat1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generateFormat1.Location = new System.Drawing.Point(134, 635);
            this.btn_generateFormat1.Name = "btn_generateFormat1";
            this.btn_generateFormat1.Size = new System.Drawing.Size(133, 54);
            this.btn_generateFormat1.TabIndex = 0;
            this.btn_generateFormat1.Text = "Format 1";
            this.btn_generateFormat1.UseVisualStyleBackColor = true;
            this.btn_generateFormat1.Click += new System.EventHandler(this.btn_generateFormat1_Click);
            // 
            // btn_generateFormat2
            // 
            this.btn_generateFormat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateFormat2.Font = new System.Drawing.Font("SF UI  Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateFormat2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generateFormat2.Location = new System.Drawing.Point(474, 635);
            this.btn_generateFormat2.Name = "btn_generateFormat2";
            this.btn_generateFormat2.Size = new System.Drawing.Size(133, 54);
            this.btn_generateFormat2.TabIndex = 1;
            this.btn_generateFormat2.Text = "Format 2";
            this.btn_generateFormat2.UseVisualStyleBackColor = true;
            this.btn_generateFormat2.Click += new System.EventHandler(this.btn_generateFormat2_Click);
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uploadImage.Font = new System.Drawing.Font("SF UI  Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uploadImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_uploadImage.Location = new System.Drawing.Point(279, 23);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(186, 54);
            this.btn_uploadImage.TabIndex = 2;
            this.btn_uploadImage.Text = "Upload Profile Image";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a template:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CVbuilder.Properties.Resources.temp_2;
            this.pictureBox2.Location = new System.Drawing.Point(391, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 502);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CVbuilder.Properties.Resources.temp_1;
            this.pictureBox1.Location = new System.Drawing.Point(56, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(746, 702);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uploadImage);
            this.Controls.Add(this.btn_generateFormat2);
            this.Controls.Add(this.btn_generateFormat1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generateFormat1;
        private System.Windows.Forms.Button btn_generateFormat2;
        private System.Windows.Forms.Button btn_uploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}