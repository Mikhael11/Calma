﻿namespace Calma.Control
{
    partial class Add_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addtxtcat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnaddcatg = new Guna.UI2.WinForms.Guna2Button();
            this.Rmvbtncatg = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(366, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(366, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(369, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtCatg
            // 
            this.txtCatg.BackColor = System.Drawing.Color.Transparent;
            this.txtCatg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCatg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCatg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtCatg.ItemHeight = 30;
            this.txtCatg.Items.AddRange(new object[] {
            "Hot Drinks",
            "Cold Drinks",
            "Moctails",
            "Healthy Moctails",
            "Soft Drinks",
            "MilkShakes",
            "Smoothies",
            "Special Smoothies",
            "Fresh Juice",
            "Mojito",
            "Extra Flavors",
            "Deserts",
            "BITES",
            "Fries",
            "Sandwiches",
            "Meals"});
            this.txtCatg.Location = new System.Drawing.Point(378, 160);
            this.txtCatg.Name = "txtCatg";
            this.txtCatg.Size = new System.Drawing.Size(212, 36);
            this.txtCatg.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCatg.TabIndex = 3;
            this.txtCatg.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(378, 350);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(212, 34);
            this.txtItemName.TabIndex = 4;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(378, 540);
            this.txtItemPrice.Multiline = true;
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(212, 34);
            this.txtItemPrice.TabIndex = 5;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BorderRadius = 15;
            this.btnAddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddItem.FillColor = System.Drawing.Color.LightCoral;
            this.btnAddItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(371, 635);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(187, 42);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "ADD";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(360, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add New Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addtxtcat
            // 
            this.addtxtcat.Location = new System.Drawing.Point(20, 162);
            this.addtxtcat.Multiline = true;
            this.addtxtcat.Name = "addtxtcat";
            this.addtxtcat.Size = new System.Drawing.Size(212, 34);
            this.addtxtcat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category name";
            // 
            // btnaddcatg
            // 
            this.btnaddcatg.BorderRadius = 15;
            this.btnaddcatg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddcatg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddcatg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddcatg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddcatg.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnaddcatg.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddcatg.ForeColor = System.Drawing.Color.Black;
            this.btnaddcatg.Location = new System.Drawing.Point(20, 248);
            this.btnaddcatg.Name = "btnaddcatg";
            this.btnaddcatg.Size = new System.Drawing.Size(187, 42);
            this.btnaddcatg.TabIndex = 10;
            this.btnaddcatg.Text = "ADD Catg.";
            this.btnaddcatg.Click += new System.EventHandler(this.btnaddcatg_Click);
            // 
            // Rmvbtncatg
            // 
            this.Rmvbtncatg.BorderRadius = 15;
            this.Rmvbtncatg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rmvbtncatg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rmvbtncatg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rmvbtncatg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rmvbtncatg.FillColor = System.Drawing.Color.PapayaWhip;
            this.Rmvbtncatg.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rmvbtncatg.ForeColor = System.Drawing.Color.Black;
            this.Rmvbtncatg.Location = new System.Drawing.Point(20, 318);
            this.Rmvbtncatg.Name = "Rmvbtncatg";
            this.Rmvbtncatg.Size = new System.Drawing.Size(187, 42);
            this.Rmvbtncatg.TabIndex = 11;
            this.Rmvbtncatg.Text = "REMOVE Catg.";
            this.Rmvbtncatg.Click += new System.EventHandler(this.Rmvbtncatg_Click);
            // 
            // Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.Rmvbtncatg);
            this.Controls.Add(this.btnaddcatg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addtxtcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtCatg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Item";
            this.Size = new System.Drawing.Size(974, 765);
            this.Load += new System.EventHandler(this.Add_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox txtCatg;
        private TextBox txtItemName;
        private TextBox txtItemPrice;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Label label4;
        private TextBox addtxtcat;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnaddcatg;
        private Guna.UI2.WinForms.Guna2Button Rmvbtncatg;
    }
}
