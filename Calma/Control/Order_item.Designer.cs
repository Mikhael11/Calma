namespace Calma.Control
{
    partial class Order_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_item));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.combocatg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCard = new Guna.UI2.WinForms.Guna2Button();
            this.texttotalorder = new System.Windows.Forms.TextBox();
            this.textpriceorder = new System.Windows.Forms.TextBox();
            this.textnameorder = new System.Windows.Forms.TextBox();
            this.numorder = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rmvdata = new Guna.UI2.WinForms.Guna2Button();
            this.Print = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coloumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtService = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textdisc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.discbtn = new Guna.UI2.WinForms.Guna2Button();
            this.safarbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // combocatg
            // 
            this.combocatg.BackColor = System.Drawing.Color.Transparent;
            this.combocatg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combocatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocatg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combocatg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combocatg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combocatg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combocatg.ItemHeight = 30;
            this.combocatg.Items.AddRange(new object[] {
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
            this.combocatg.Location = new System.Drawing.Point(17, 82);
            this.combocatg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combocatg.Name = "combocatg";
            this.combocatg.Size = new System.Drawing.Size(182, 36);
            this.combocatg.TabIndex = 1;
            this.combocatg.SelectedIndexChanged += new System.EventHandler(this.combocatg_SelectedIndexChanged);
            // 
            // txtSrch
            // 
            this.txtSrch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSrch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtSrch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSrch.Location = new System.Drawing.Point(17, 130);
            this.txtSrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSrch.Multiline = true;
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.PlaceholderText = "Search";
            this.txtSrch.Size = new System.Drawing.Size(182, 24);
            this.txtSrch.TabIndex = 2;
            this.txtSrch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSrch.TextChanged += new System.EventHandler(this.txtSrch_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(17, 168);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 394);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(327, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Make an Order";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtdisc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCard);
            this.panel1.Controls.Add(this.texttotalorder);
            this.panel1.Controls.Add(this.textpriceorder);
            this.panel1.Controls.Add(this.textnameorder);
            this.panel1.Controls.Add(this.numorder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(228, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 160);
            this.panel1.TabIndex = 5;
            // 
            // txtdisc
            // 
            this.txtdisc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtdisc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtdisc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdisc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdisc.Location = new System.Drawing.Point(427, 40);
            this.txtdisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdisc.Multiline = true;
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(154, 24);
            this.txtdisc.TabIndex = 15;
            this.txtdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(426, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Discount";
            // 
            // btnCard
            // 
            this.btnCard.BorderRadius = 26;
            this.btnCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCard.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCard.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCard.ForeColor = System.Drawing.Color.White;
            this.btnCard.Location = new System.Drawing.Point(415, 94);
            this.btnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(174, 42);
            this.btnCard.TabIndex = 13;
            this.btnCard.Text = "Shof el 7esab";
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // texttotalorder
            // 
            this.texttotalorder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.texttotalorder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.texttotalorder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texttotalorder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texttotalorder.Location = new System.Drawing.Point(231, 111);
            this.texttotalorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texttotalorder.Multiline = true;
            this.texttotalorder.Name = "texttotalorder";
            this.texttotalorder.ReadOnly = true;
            this.texttotalorder.Size = new System.Drawing.Size(154, 25);
            this.texttotalorder.TabIndex = 12;
            this.texttotalorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texttotalorder.TextChanged += new System.EventHandler(this.texttotalorder_TextChanged);
            // 
            // textpriceorder
            // 
            this.textpriceorder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textpriceorder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textpriceorder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textpriceorder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textpriceorder.Location = new System.Drawing.Point(231, 40);
            this.textpriceorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textpriceorder.Multiline = true;
            this.textpriceorder.Name = "textpriceorder";
            this.textpriceorder.Size = new System.Drawing.Size(154, 24);
            this.textpriceorder.TabIndex = 11;
            this.textpriceorder.Text = "0";
            this.textpriceorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textpriceorder.TextChanged += new System.EventHandler(this.textpriceorder_TextChanged);
            // 
            // textnameorder
            // 
            this.textnameorder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textnameorder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textnameorder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textnameorder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textnameorder.Location = new System.Drawing.Point(19, 40);
            this.textnameorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textnameorder.Multiline = true;
            this.textnameorder.Name = "textnameorder";
            this.textnameorder.ReadOnly = true;
            this.textnameorder.Size = new System.Drawing.Size(168, 24);
            this.textnameorder.TabIndex = 6;
            this.textnameorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numorder
            // 
            this.numorder.BackColor = System.Drawing.Color.Transparent;
            this.numorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numorder.Location = new System.Drawing.Point(19, 111);
            this.numorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numorder.Name = "numorder";
            this.numorder.Size = new System.Drawing.Size(168, 25);
            this.numorder.TabIndex = 10;
            this.numorder.ValueChanged += new System.EventHandler(this.numorder_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(230, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(230, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Name";
            // 
            // Rmvdata
            // 
            this.Rmvdata.BorderRadius = 26;
            this.Rmvdata.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rmvdata.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rmvdata.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rmvdata.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rmvdata.FillColor = System.Drawing.Color.RoyalBlue;
            this.Rmvdata.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rmvdata.ForeColor = System.Drawing.Color.White;
            this.Rmvdata.Location = new System.Drawing.Point(228, 509);
            this.Rmvdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rmvdata.Name = "Rmvdata";
            this.Rmvdata.Size = new System.Drawing.Size(177, 42);
            this.Rmvdata.TabIndex = 14;
            this.Rmvdata.Text = "Remove";
            this.Rmvdata.Click += new System.EventHandler(this.Rmvdata_Click);
            // 
            // Print
            // 
            this.Print.BorderRadius = 26;
            this.Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.Print.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Print.ForeColor = System.Drawing.Color.White;
            this.Print.Location = new System.Drawing.Point(647, 509);
            this.Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(177, 42);
            this.Print.TabIndex = 15;
            this.Print.Text = "Etb3 ya ma3lem";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(675, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalPrice.Location = new System.Drawing.Point(663, 464);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(120, 32);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "LE";
            this.txtTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTotalPrice.Click += new System.EventHandler(this.txtTotalPrice_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Coloumn3
            // 
            this.Coloumn3.HeaderText = "Quantity";
            this.Coloumn3.MinimumWidth = 6;
            this.Coloumn3.Name = "Coloumn3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price/one";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 27;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Coloumn3,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(228, 248);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 29;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(591, 181);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // txtService
            // 
            this.txtService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtService.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtService.Location = new System.Drawing.Point(512, 464);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(120, 32);
            this.txtService.TabIndex = 18;
            this.txtService.Text = "LE";
            this.txtService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtService.Click += new System.EventHandler(this.txtService_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(524, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Service";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(218, 464);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 32);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.Text = "LE";
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(230, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Price";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textdisc
            // 
            this.textdisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textdisc.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textdisc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textdisc.Location = new System.Drawing.Point(371, 464);
            this.textdisc.Name = "textdisc";
            this.textdisc.Size = new System.Drawing.Size(120, 32);
            this.textdisc.TabIndex = 23;
            this.textdisc.Text = "LE";
            this.textdisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(383, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Price/disc";
            // 
            // discbtn
            // 
            this.discbtn.BorderRadius = 26;
            this.discbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.discbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.discbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.discbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.discbtn.FillColor = System.Drawing.Color.DarkRed;
            this.discbtn.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discbtn.ForeColor = System.Drawing.Color.White;
            this.discbtn.Location = new System.Drawing.Point(438, 509);
            this.discbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discbtn.Name = "discbtn";
            this.discbtn.Size = new System.Drawing.Size(177, 42);
            this.discbtn.TabIndex = 24;
            this.discbtn.Text = "Add disc";
            this.discbtn.Click += new System.EventHandler(this.discbtn_Click);
            // 
            // safarbtn
            // 
            this.safarbtn.BorderRadius = 26;
            this.safarbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.safarbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.safarbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.safarbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.safarbtn.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.safarbtn.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.safarbtn.ForeColor = System.Drawing.Color.White;
            this.safarbtn.Location = new System.Drawing.Point(820, 335);
            this.safarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.safarbtn.Name = "safarbtn";
            this.safarbtn.Size = new System.Drawing.Size(39, 42);
            this.safarbtn.TabIndex = 25;
            this.safarbtn.Text = "z";
            this.safarbtn.Click += new System.EventHandler(this.safarbtn_Click);
            // 
            // Order_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.safarbtn);
            this.Controls.Add(this.discbtn);
            this.Controls.Add(this.textdisc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Rmvdata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.combocatg);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order_item";
            this.Size = new System.Drawing.Size(852, 580);
            this.Load += new System.EventHandler(this.Order_item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox combocatg;
        private TextBox txtSrch;
        private ListBox listBox1;
        private Label label2;
        private Panel panel1;
        private TextBox texttotalorder;
        private TextBox textpriceorder;
        private TextBox textnameorder;
        private Guna.UI2.WinForms.Guna2NumericUpDown numorder;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCard;
        private Guna.UI2.WinForms.Guna2Button Rmvdata;
        private Guna.UI2.WinForms.Guna2Button Print;
        private Label label7;
        private Label txtTotalPrice;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Coloumn3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label txtService;
        private Label label9;
        private Label txtPrice;
        private Label label11;
        private TextBox txtdisc;
        private Label label8;
        private Label textdisc;
        private Label label12;
        private Guna.UI2.WinForms.Guna2Button discbtn;
        private Guna.UI2.WinForms.Guna2Button safarbtn;
    }
}
