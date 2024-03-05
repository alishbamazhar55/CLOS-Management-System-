
namespace DBMIDPROJECT
{
    partial class CLO
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
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clo21 = new DBMIDPROJECT.Clo2();
            this.clO11 = new DBMIDPROJECT.CLO1();
            this.clo31 = new DBMIDPROJECT.Clo3();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage CLO\'S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = "Management of CLO\'S";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "View/Search Student";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD CLO\'S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 66);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update/Delete Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 636);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 66);
            this.button3.TabIndex = 8;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMIDPROJECT.Properties.Resources.learning_outcomes_header3x_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(333, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clo21
            // 
            this.clo21.BackColor = System.Drawing.Color.RosyBrown;
            this.clo21.Location = new System.Drawing.Point(251, -2);
            this.clo21.Name = "clo21";
            this.clo21.Size = new System.Drawing.Size(964, 730);
            this.clo21.TabIndex = 10;
            // 
            // clO11
            // 
            this.clO11.BackColor = System.Drawing.Color.RosyBrown;
            this.clO11.Location = new System.Drawing.Point(251, 1);
            this.clO11.Name = "clO11";
            this.clO11.Size = new System.Drawing.Size(964, 727);
            this.clO11.TabIndex = 9;
            // 
            // clo31
            // 
            this.clo31.BackColor = System.Drawing.Color.RosyBrown;
            this.clo31.Location = new System.Drawing.Point(251, 1);
            this.clo31.Name = "clo31";
            this.clo31.Size = new System.Drawing.Size(964, 727);
            this.clo31.TabIndex = 11;
            // 
            // CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 724);
            this.Controls.Add(this.clo31);
            this.Controls.Add(this.clo21);
            this.Controls.Add(this.clO11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CLO";
            this.Text = "CLO";
            this.Load += new System.EventHandler(this.CLO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private CLO1 clO11;
        private Clo2 clo21;
        private Clo3 clo31;
    }
}