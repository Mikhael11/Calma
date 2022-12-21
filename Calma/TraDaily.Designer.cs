namespace Calma
{
    partial class TraDaily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraDaily));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tran_daily1 = new Calma.Control.Tran_daily();
            this.Logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.tran_daily1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 600);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(946, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit.Size = new System.Drawing.Size(40, 33);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tran_daily1
            // 
            this.tran_daily1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tran_daily1.Location = new System.Drawing.Point(25, 23);
            this.tran_daily1.Name = "tran_daily1";
            this.tran_daily1.Size = new System.Drawing.Size(961, 594);
            this.tran_daily1.TabIndex = 0;
            this.tran_daily1.Load += new System.EventHandler(this.tran_daily1_Load);
            // 
            // Logout
            // 
            this.Logout.BorderRadius = 26;
            this.Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout.FillColor = System.Drawing.Color.Teal;
            this.Logout.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(845, 552);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(141, 45);
            this.Logout.TabIndex = 28;
            this.Logout.Text = "Log out";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // TraDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraDaily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraDaily";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Control.Tran_daily tran_daily1;
        private Guna.UI2.WinForms.Guna2CircleButton Exit;
        private Guna.UI2.WinForms.Guna2Button Logout;
    }
}