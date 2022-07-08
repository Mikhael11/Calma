namespace Calma
{
    partial class Dashboard
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
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Printdaily = new Guna.UI2.WinForms.Guna2Button();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dayprint1 = new Calma.Control.Dayprint();
            this.remove_Item1 = new Calma.Control.Remove_Item();
            this.update_Item1 = new Calma.Control.Update_Item();
            this.order_item1 = new Calma.Control.Order_item();
            this.add_Item1 = new Calma.Control.Add_Item();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BorderRadius = 26;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.btnOrder.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(23, 70);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(199, 56);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 26;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.btnAdd.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(23, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 26;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.btnUpdate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(23, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 56);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 26;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.btnRemove.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(23, 477);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(199, 56);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.Printdaily);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 734);
            this.panel1.TabIndex = 0;
            // 
            // Printdaily
            // 
            this.Printdaily.BorderRadius = 26;
            this.Printdaily.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Printdaily.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Printdaily.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Printdaily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Printdaily.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.Printdaily.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Printdaily.ForeColor = System.Drawing.Color.White;
            this.Printdaily.Location = new System.Drawing.Point(23, 583);
            this.Printdaily.Name = "Printdaily";
            this.Printdaily.Size = new System.Drawing.Size(199, 56);
            this.Printdaily.TabIndex = 5;
            this.Printdaily.Text = "Print daily";
            this.Printdaily.Click += new System.EventHandler(this.Printdaily_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Segoe UI Historic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.Logout.Location = new System.Drawing.Point(59, 691);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(90, 28);
            this.Logout.TabIndex = 4;
            this.Logout.TabStop = true;
            this.Logout.Text = "Log Out";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.dayprint1);
            this.panel2.Controls.Add(this.remove_Item1);
            this.panel2.Controls.Add(this.update_Item1);
            this.panel2.Controls.Add(this.order_item1);
            this.panel2.Controls.Add(this.add_Item1);
            this.panel2.Location = new System.Drawing.Point(224, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 765);
            this.panel2.TabIndex = 0;
            // 
            // dayprint1
            // 
            this.dayprint1.BackColor = System.Drawing.Color.AliceBlue;
            this.dayprint1.Location = new System.Drawing.Point(0, 0);
            this.dayprint1.Name = "dayprint1";
            this.dayprint1.Size = new System.Drawing.Size(1074, 874);
            this.dayprint1.TabIndex = 4;
            // 
            // remove_Item1
            // 
            this.remove_Item1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.remove_Item1.Location = new System.Drawing.Point(-3, 0);
            this.remove_Item1.Name = "remove_Item1";
            this.remove_Item1.Size = new System.Drawing.Size(974, 755);
            this.remove_Item1.TabIndex = 3;
            // 
            // update_Item1
            // 
            this.update_Item1.Location = new System.Drawing.Point(0, 0);
            this.update_Item1.Name = "update_Item1";
            this.update_Item1.Size = new System.Drawing.Size(986, 758);
            this.update_Item1.TabIndex = 2;
            // 
            // order_item1
            // 
            this.order_item1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.order_item1.Location = new System.Drawing.Point(0, 0);
            this.order_item1.Name = "order_item1";
            this.order_item1.Size = new System.Drawing.Size(971, 778);
            this.order_item1.TabIndex = 1;
            // 
            // add_Item1
            // 
            this.add_Item1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Item1.Location = new System.Drawing.Point(0, 3);
            this.add_Item1.Name = "add_Item1";
            this.add_Item1.Size = new System.Drawing.Size(971, 765);
            this.add_Item1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1192, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Panel panel1;
        private LinkLabel Logout;
        private Panel panel2;
        private Control.Add_Item add_Item1;
        private Control.Order_item order_item1;
        private Control.Update_Item update_Item1;
        private Control.Remove_Item remove_Item1;
        private Guna.UI2.WinForms.Guna2Button Printdaily;
        private Control.Dayprint dayprint1;
    }
}