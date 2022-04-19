namespace Pookie_Photos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlebar = new System.Windows.Forms.Panel();
            this.Settingsbut = new System.Windows.Forms.Button();
            this.minibut = new System.Windows.Forms.Button();
            this.exitbut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenButt = new System.Windows.Forms.Button();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.titlebar.Controls.Add(this.Settingsbut);
            this.titlebar.Controls.Add(this.minibut);
            this.titlebar.Controls.Add(this.exitbut);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1050, 25);
            this.titlebar.TabIndex = 0;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Settingsbut
            // 
            this.Settingsbut.Dock = System.Windows.Forms.DockStyle.Right;
            this.Settingsbut.FlatAppearance.BorderSize = 0;
            this.Settingsbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.Settingsbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settingsbut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Settingsbut.ForeColor = System.Drawing.Color.White;
            this.Settingsbut.Location = new System.Drawing.Point(907, 0);
            this.Settingsbut.Name = "Settingsbut";
            this.Settingsbut.Size = new System.Drawing.Size(45, 25);
            this.Settingsbut.TabIndex = 3;
            this.Settingsbut.Text = "⚙";
            this.Settingsbut.UseVisualStyleBackColor = true;
            // 
            // minibut
            // 
            this.minibut.BackColor = System.Drawing.Color.Transparent;
            this.minibut.Dock = System.Windows.Forms.DockStyle.Right;
            this.minibut.FlatAppearance.BorderSize = 0;
            this.minibut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.minibut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minibut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.minibut.Location = new System.Drawing.Point(952, 0);
            this.minibut.Name = "minibut";
            this.minibut.Size = new System.Drawing.Size(49, 25);
            this.minibut.TabIndex = 2;
            this.minibut.Text = "-";
            this.minibut.UseVisualStyleBackColor = false;
            this.minibut.Click += new System.EventHandler(this.minibut_Click);
            // 
            // exitbut
            // 
            this.exitbut.BackColor = System.Drawing.Color.Transparent;
            this.exitbut.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitbut.FlatAppearance.BorderSize = 0;
            this.exitbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.exitbut.Location = new System.Drawing.Point(1001, 0);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(49, 25);
            this.exitbut.TabIndex = 1;
            this.exitbut.Text = "X";
            this.exitbut.UseVisualStyleBackColor = false;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(438, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // OpenButt
            // 
            this.OpenButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenButt.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenButt.Location = new System.Drawing.Point(447, 307);
            this.OpenButt.Name = "OpenButt";
            this.OpenButt.Size = new System.Drawing.Size(85, 36);
            this.OpenButt.TabIndex = 3;
            this.OpenButt.Text = "Open";
            this.OpenButt.UseVisualStyleBackColor = true;
            this.OpenButt.Click += new System.EventHandler(this.OpenButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1050, 583);
            this.Controls.Add(this.OpenButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pookie Photo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel titlebar;
        private Button minibut;
        private Button exitbut;
        private Label label1;
        private Button Settingsbut;
        private PictureBox pictureBox1;
        private Button OpenButt;
    }
}