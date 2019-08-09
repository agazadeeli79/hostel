namespace Hostelnew
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
            this.label1 = new System.Windows.Forms.Label();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.btnworkers = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(217, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom To Our Hostel";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(161, 96);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(475, 245);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcImage.TabIndex = 1;
            this.pcImage.TabStop = false;
            // 
            // btnworkers
            // 
            this.btnworkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnworkers.Location = new System.Drawing.Point(72, 369);
            this.btnworkers.Name = "btnworkers";
            this.btnworkers.Size = new System.Drawing.Size(121, 43);
            this.btnworkers.TabIndex = 2;
            this.btnworkers.Text = "Workers";
            this.btnworkers.UseVisualStyleBackColor = true;
            this.btnworkers.Click += new System.EventHandler(this.Btnworkers_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadmin.Location = new System.Drawing.Point(584, 383);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(144, 43);
            this.btnadmin.TabIndex = 3;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.Btnadmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnworkers);
            this.Controls.Add(this.pcImage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Button btnworkers;
        private System.Windows.Forms.Button btnadmin;
    }
}

