
namespace DBMIDPROJECT
{
    partial class AssessmentComponent
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
            this.deleteAC1 = new DBMIDPROJECT.DeleteAC();
            this.viewAC1 = new DBMIDPROJECT.ViewAC();
            this.addAC1 = new DBMIDPROJECT.AddAC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 620);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 66);
            this.button5.TabIndex = 15;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 78);
            this.button4.TabIndex = 14;
            this.button4.Text = "View/Search Assessment Component\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 74);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete/Update Assessment Component\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Assessment Component";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 76);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Assessments\r\n   Components\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(346, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 64);
            this.label2.TabIndex = 16;
            this.label2.Text = "Management of Assessments Components\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMIDPROJECT.Properties.Resources.images_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(329, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // deleteAC1
            // 
            this.deleteAC1.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteAC1.Location = new System.Drawing.Point(252, 1);
            this.deleteAC1.Name = "deleteAC1";
            this.deleteAC1.Size = new System.Drawing.Size(964, 739);
            this.deleteAC1.TabIndex = 20;
            this.deleteAC1.Load += new System.EventHandler(this.deleteAC1_Load);
            // 
            // viewAC1
            // 
            this.viewAC1.BackColor = System.Drawing.Color.RosyBrown;
            this.viewAC1.Location = new System.Drawing.Point(252, 1);
            this.viewAC1.Name = "viewAC1";
            this.viewAC1.Size = new System.Drawing.Size(962, 722);
            this.viewAC1.TabIndex = 19;
            // 
            // addAC1
            // 
            this.addAC1.BackColor = System.Drawing.Color.RosyBrown;
            this.addAC1.Location = new System.Drawing.Point(252, 1);
            this.addAC1.Name = "addAC1";
            this.addAC1.Size = new System.Drawing.Size(962, 722);
            this.addAC1.TabIndex = 18;
            // 
            // AssessmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 724);
            this.Controls.Add(this.deleteAC1);
            this.Controls.Add(this.viewAC1);
            this.Controls.Add(this.addAC1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AssessmentComponent";
            this.Text = "AssessmentComponent";
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
        private AddAC addAC1;
        private ViewAC viewAC1;
        private DeleteAC deleteAC1;
    }
}