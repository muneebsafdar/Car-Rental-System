namespace CarRentalManagementSystem

{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Progressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Progressload = new System.Windows.Forms.Timer(this.components);
            this.progressvalue = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Progressbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Progressbar
            // 
            this.Progressbar.Controls.Add(this.guna2CirclePictureBox1);
            this.Progressbar.FillColor = System.Drawing.Color.Black;
            this.Progressbar.FillThickness = 12;
            this.Progressbar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Progressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.Progressbar.Location = new System.Drawing.Point(293, 68);
            this.Progressbar.Minimum = 0;
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.Progressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.Progressbar.ProgressThickness = 12;
            this.Progressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Progressbar.Size = new System.Drawing.Size(386, 386);
            this.Progressbar.TabIndex = 1;
            this.Progressbar.Text = "guna2CircleProgressBar1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pngegg;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(80, 83);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(232, 218);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(219, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Powered by Muneeb Co.  Ltd";
            // 
            // Progressload
            // 
            this.Progressload.Enabled = true;
            this.Progressload.Interval = 20;
            this.Progressload.Tick += new System.EventHandler(this.Progressload_Tick);
            // 
            // progressvalue
            // 
            this.progressvalue.AutoSize = true;
            this.progressvalue.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressvalue.ForeColor = System.Drawing.Color.White;
            this.progressvalue.Location = new System.Drawing.Point(450, 474);
            this.progressvalue.Name = "progressvalue";
            this.progressvalue.Size = new System.Drawing.Size(0, 24);
            this.progressvalue.TabIndex = 4;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.progressvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Progressbar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Progressbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Progressbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Progressload;
        private System.Windows.Forms.Label progressvalue;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

