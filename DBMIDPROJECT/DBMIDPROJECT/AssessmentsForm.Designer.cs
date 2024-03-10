
namespace DBMIDPROJECT
{
    partial class AssessmentsForm
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteAssessment1 = new DBMIDPROJECT.DeleteAssessment();
            this.assessmentView1 = new DBMIDPROJECT.AssessmentView();
            this.assessment1 = new DBMIDPROJECT.Assessment();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 618);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 66);
            this.button5.TabIndex = 10;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 66);
            this.button4.TabIndex = 9;
            this.button4.Text = "View/Search Assessment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 66);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete/Update Assessment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Assessment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Assessments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(721, 85);
            this.label2.TabIndex = 11;
            this.label2.Text = "Management of Assessments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMIDPROJECT.Properties.Resources.assessment_concept_with_icons_and_signs_vector_29533961_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(359, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // deleteAssessment1
            // 
            this.deleteAssessment1.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteAssessment1.Location = new System.Drawing.Point(300, 0);
            this.deleteAssessment1.Name = "deleteAssessment1";
            this.deleteAssessment1.Size = new System.Drawing.Size(964, 739);
            this.deleteAssessment1.TabIndex = 15;
            this.deleteAssessment1.Load += new System.EventHandler(this.deleteAssessment1_Load);
            // 
            // assessmentView1
            // 
            this.assessmentView1.BackColor = System.Drawing.Color.RosyBrown;
            this.assessmentView1.Location = new System.Drawing.Point(300, 0);
            this.assessmentView1.Name = "assessmentView1";
            this.assessmentView1.Size = new System.Drawing.Size(964, 739);
            this.assessmentView1.TabIndex = 14;
            // 
            // assessment1
            // 
            this.assessment1.BackColor = System.Drawing.Color.RosyBrown;
            this.assessment1.Location = new System.Drawing.Point(300, 0);
            this.assessment1.Name = "assessment1";
            this.assessment1.Size = new System.Drawing.Size(913, 732);
            this.assessment1.TabIndex = 13;
            // 
            // AssessmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 724);
            this.Controls.Add(this.deleteAssessment1);
            this.Controls.Add(this.assessmentView1);
            this.Controls.Add(this.assessment1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1236, 780);
            this.MinimumSize = new System.Drawing.Size(1236, 780);
            this.Name = "AssessmentsForm";
            this.Text = "AssessmentsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssessmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.AssessmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Assessment assessment1;
        private AssessmentView assessmentView1;
        private DeleteAssessment deleteAssessment1;
    }
}