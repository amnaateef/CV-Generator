using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Colors;

namespace CVbuilder
{
    public partial class Form2 : Form
    {
        private CVData cvData;

        private string imagePath; 

        public Form2(CVData cvData)
        {
            InitializeComponent();
            this.cvData = cvData ?? new CVData();
        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Store the image path
                imagePath = openFileDialog.FileName;

                MessageBox.Show("Image uploaded successfully!");
            }
        }

        private void btn_generateFormat1_Click(object sender, EventArgs e)
        {
            CreatePdfCV("CV_Format1.pdf", cvData.GeneralInfo.Name, cvData.GeneralInfo.Gender, cvData.GeneralInfo.Dob, cvData.GeneralInfo.Address, cvData.Skills.SkillsList, cvData.Skills.SkillDeses, cvData.Education.Institutes, cvData.Education.EduDeses, cvData.Work.WorkPlaces, cvData.Work.WorkDeses, cvData.Education.Quals, cvData.Education.QualDeses, cvData.Skills.Hobbies, cvData.Skills.HobbyDeses, imagePath);
            MessageBox.Show("CV (Format 1) generated successfully!");
        }

        public void CreatePdfCV(string filename, string name, string gender, string dob, string address, List<string> skills, List<string> skillDescriptions, List<string> edus, List<string> eduDescriptions, List<string> works, List<string> workDescriptions, List<string> quals, List<string> qualDescriptions, List<string> hobbies, List<string> hobbyDescriptions, string imagePath)
        {
            var writer = new PdfWriter(filename);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            // Set up fonts
            var font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            // Add user's picture
            if (!string.IsNullOrEmpty(imagePath))
            {
                ImageData imageData = ImageDataFactory.Create(imagePath);
                iText.Layout.Element.Image image = new iText.Layout.Element.Image(imageData);
                image.ScaleToFit(100, 100);
                image.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                document.Add(image);
            }

            var stitle = new Paragraph(" ")
                .SetFont(boldFont)
                .SetFontSize(30);
            document.Add(stitle);

            // Title (User's Name)
            var title = new Paragraph(name)
                .SetFont(boldFont)
                .SetFontSize(30);
            document.Add(title);

            // Subheadings (Gender, DOB, Address)
            document.Add(new Paragraph("Gender:").SetFont(boldFont).SetFontSize(12));
            document.Add(new Paragraph(gender).SetFont(font).SetFontSize(12));
            document.Add(new Paragraph("DOB:").SetFont(boldFont).SetFontSize(12));
            document.Add(new Paragraph(dob).SetFont(font).SetFontSize(12));
            document.Add(new Paragraph("Address:").SetFont(boldFont).SetFontSize(12));
            document.Add(new Paragraph(address).SetFont(font).SetFontSize(12));

            // Skills
            document.Add(new Paragraph("Skills").SetFont(boldFont).SetFontSize(18));
            for (int i = 0; i < skills.Count; i++)
            {
                document.Add(new Paragraph(skills[i]).SetFont(boldFont).SetFontSize(12));
                document.Add(new Paragraph(skillDescriptions[i]).SetFont(font).SetFontSize(12));
            }

            // Education
            document.Add(new Paragraph("Education").SetFont(boldFont).SetFontSize(18));
            for (int i = 0; i < edus.Count; i++)
            {
                document.Add(new Paragraph(edus[i]).SetFont(boldFont).SetFontSize(12));
                document.Add(new Paragraph(eduDescriptions[i]).SetFont(font).SetFontSize(12));
            }

            // Work
            document.Add(new Paragraph("Work").SetFont(boldFont).SetFontSize(18));
            for (int i = 0; i < works.Count; i++)
            {
                document.Add(new Paragraph(works[i]).SetFont(boldFont).SetFontSize(12));
                document.Add(new Paragraph(workDescriptions[i]).SetFont(font).SetFontSize(12));
            }

            // Qualifications
            document.Add(new Paragraph("Qualifications").SetFont(boldFont).SetFontSize(18));
            for (int i = 0; i < quals.Count; i++)
            {
                document.Add(new Paragraph(quals[i]).SetFont(boldFont).SetFontSize(12));
                document.Add(new Paragraph(qualDescriptions[i]).SetFont(font).SetFontSize(12));
            }

            // Hobbies
            document.Add(new Paragraph("Hobbies").SetFont(boldFont).SetFontSize(18));
            for (int i = 0; i < hobbies.Count; i++)
            {
                document.Add(new Paragraph(hobbies[i]).SetFont(boldFont).SetFontSize(12));
                document.Add(new Paragraph(hobbyDescriptions[i]).SetFont(font).SetFontSize(12));
            }

            document.Close();
        }


        private void btn_generateFormat2_Click(object sender, EventArgs e)
        {
            CreatePdfCV2("CV_Format2.pdf", cvData.GeneralInfo.Name, cvData.GeneralInfo.Gender, cvData.GeneralInfo.Dob, cvData.GeneralInfo.Address, cvData.Skills.SkillsList, cvData.Skills.SkillDeses, cvData.Education.Institutes, cvData.Education.EduDeses, cvData.Work.WorkPlaces, cvData.Work.WorkDeses, cvData.Education.Quals, cvData.Education.QualDeses, cvData.Skills.Hobbies, cvData.Skills.HobbyDeses, imagePath);
            MessageBox.Show("CV (Format 2) generated successfully!");
        }

        public void CreatePdfCV2(string filename, string name, string gender, string dob, string address, List<string> skills, List<string> skillDescriptions, List<string> edus, List<string> eduDescriptions, List<string> works, List<string> workDescriptions, List<string> quals, List<string> qualDescriptions, List<string> hobbies, List<string> hobbyDescriptions, string imagePath)
        {
            var writer = new PdfWriter(filename);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            // Set up fonts
            var font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);  // Use a different font family
            var boldFont = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);  // Use a different font family for bold text

            // Set up colors
            var blackColor = new DeviceRgb(0, 0, 0);
            var darkBlueColor = new DeviceRgb(0, 0, 139);  // Dark blue color


            // Add user's picture
            if (!string.IsNullOrEmpty(imagePath))
            {
                ImageData imageData = ImageDataFactory.Create(imagePath);
                iText.Layout.Element.Image image = new iText.Layout.Element.Image(imageData);
                image.ScaleToFit(100, 100);
                image.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                document.Add(image);
            }

            var stitle = new Paragraph(" ")
                .SetFont(boldFont)
                .SetFontSize(30);
            document.Add(stitle);

            // Title (User's Name)
            var title = new Paragraph(name)
                .SetFont(boldFont)
                .SetFontSize(30)
                .SetFontColor(darkBlueColor);  // Make the font color dark blue
            document.Add(title);

            // Subheadings (Gender, DOB, Address)
            document.Add(new Paragraph().Add(new Text("Gender: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(gender).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            document.Add(new Paragraph().Add(new Text("DOB: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(dob).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            document.Add(new Paragraph().Add(new Text("Address: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(address).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));

            // Skills
            document.Add(new Paragraph(new Text("Skills").SetFont(boldFont).SetFontSize(18).SetFontColor(blackColor)));
            for (int i = 0; i < skills.Count; i++)
            {
                document.Add(new Paragraph().Add(new Text($"{skills[i]}: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(skillDescriptions[i]).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            }

            // Education
            document.Add(new Paragraph(new Text("Education").SetFont(boldFont).SetFontSize(18).SetFontColor(blackColor)));
            for (int i = 0; i < edus.Count; i++)
            {
                document.Add(new Paragraph().Add(new Text($"{edus[i]}: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(eduDescriptions[i]).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            }

            // Work
            document.Add(new Paragraph(new Text("Work").SetFont(boldFont).SetFontSize(18).SetFontColor(blackColor)));
            for (int i = 0; i < works.Count; i++)
            {
                document.Add(new Paragraph().Add(new Text($"{works[i]}: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(workDescriptions[i]).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            }

            // Qualifications
            document.Add(new Paragraph(new Text("Qualifications").SetFont(boldFont).SetFontSize(18).SetFontColor(blackColor)));
            for (int i = 0; i < quals.Count; i++)
            {
                document.Add(new Paragraph().Add(new Text($"{quals[i]}: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(qualDescriptions[i]).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            }

            // Hobbies
            document.Add(new Paragraph(new Text("Hobbies").SetFont(boldFont).SetFontSize(18).SetFontColor(blackColor)));
            for (int i = 0; i < hobbies.Count; i++)
            {
                document.Add(new Paragraph().Add(new Text($"{hobbies[i]}: ").SetFont(boldFont).SetFontSize(12).SetFontColor(blackColor)).Add(new Text(hobbyDescriptions[i]).SetFont(font).SetFontSize(12).SetFontColor(blackColor)));
            }

            document.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
