
namespace DBMIDPROJECT
{
    partial class AttendenceForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.attendence1 = new DBMIDPROJECT.Attendence();
            this.viewAttendence1 = new DBMIDPROJECT.viewAttendence();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 631);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 58);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "VIew Attendence";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mark Attendence";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 100);
            this.label1.TabIndex = 7;
            this.label1.Text = "   Manage \r\nAttendence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 79);
            this.label2.TabIndex = 12;
            this.label2.Text = "  Management of Attendence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMIDPROJECT.Properties.Resources._6612108_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(424, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // attendence1
            // 
            this.attendence1.BackColor = System.Drawing.Color.RosyBrown;
            this.attendence1.Location = new System.Drawing.Point(256, 1);
            this.attendence1.Name = "attendence1";
            this.attendence1.Size = new System.Drawing.Size(962, 722);
            this.attendence1.TabIndex = 14;
            this.attendence1.Load += new System.EventHandler(this.attendence1_Load);
            // 
            // viewAttendence1
            // 
            this.viewAttendence1.BackColor = System.Drawing.Color.RosyBrown;
            this.viewAttendence1.Location = new System.Drawing.Point(256, 1);
            this.viewAttendence1.Name = "viewAttendence1";
            this.viewAttendence1.Size = new System.Drawing.Size(964, 739);
            this.viewAttendence1.TabIndex = 15;
            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 724);
            this.Controls.Add(this.attendence1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAttendence1);
            this.MaximumSize = new System.Drawing.Size(1236, 780);
            this.MinimumSize = new System.Drawing.Size(1236, 780);
            this.Name = "AttendenceForm";
            this.Text = "AttendenceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendenceForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Attendence attendence1;
        private viewAttendence viewAttendence1;
    }
}