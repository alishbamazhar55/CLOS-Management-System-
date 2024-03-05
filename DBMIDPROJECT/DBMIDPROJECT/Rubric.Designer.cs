
namespace DBMIDPROJECT
{
    partial class Rubric
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.viewRubric1 = new DBMIDPROJECT.ViewRubric();
            this.clO11 = new DBMIDPROJECT.CLO1();
            this.deleteRubric1 = new DBMIDPROJECT.DeleteRubric();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rubrics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 85);
            this.label2.TabIndex = 1;
            this.label2.Text = "Management of Rubrics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD Rubrics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMIDPROJECT.Properties.Resources.images_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(415, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "VIew/Search Rubrics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update/Delete Rubrics";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 635);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 58);
            this.button4.TabIndex = 6;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewRubric1
            // 
            this.viewRubric1.BackColor = System.Drawing.Color.RosyBrown;
            this.viewRubric1.Location = new System.Drawing.Point(251, 0);
            this.viewRubric1.Name = "viewRubric1";
            this.viewRubric1.Size = new System.Drawing.Size(962, 722);
            this.viewRubric1.TabIndex = 8;
            // 
            // clO11
            // 
            this.clO11.BackColor = System.Drawing.Color.RosyBrown;
            this.clO11.Location = new System.Drawing.Point(251, 0);
            this.clO11.Name = "clO11";
            this.clO11.Size = new System.Drawing.Size(962, 722);
            this.clO11.TabIndex = 7;
            this.clO11.Load += new System.EventHandler(this.clO11_Load);
            // 
            // deleteRubric1
            // 
            this.deleteRubric1.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteRubric1.Location = new System.Drawing.Point(251, 0);
            this.deleteRubric1.Name = "deleteRubric1";
            this.deleteRubric1.Size = new System.Drawing.Size(962, 722);
            this.deleteRubric1.TabIndex = 9;
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 724);
            this.Controls.Add(this.deleteRubric1);
            this.Controls.Add(this.viewRubric1);
            this.Controls.Add(this.clO11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rubric";
            this.Text = "Rubric";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private CLO1 clO11;
        private ViewRubric viewRubric1;
        private DeleteRubric deleteRubric1;
    }
}