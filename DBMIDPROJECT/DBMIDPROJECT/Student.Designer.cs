
namespace DBMIDPROJECT
{
    partial class Student
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl31 = new DBMIDPROJECT.UserControl3();
            this.userControl21 = new DBMIDPROJECT.UserControl2();
            this.userControl11 = new DBMIDPROJECT.UserControl1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Students";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete/Update Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "View/Search Student";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 646);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 85);
            this.label2.TabIndex = 10;
            this.label2.Text = "Management of Students ";
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.RosyBrown;
            this.userControl31.Location = new System.Drawing.Point(303, -1);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(921, 720);
            this.userControl31.TabIndex = 8;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.RosyBrown;
            this.userControl21.Location = new System.Drawing.Point(303, -1);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(913, 732);
            this.userControl21.TabIndex = 7;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.RosyBrown;
            this.userControl11.Location = new System.Drawing.Point(303, -1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(915, 732);
            this.userControl11.TabIndex = 6;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMIDPROJECT.Properties.Resources.png_clipart_leadership_management_student_leader_business_student_blue_text_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(353, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 724);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}