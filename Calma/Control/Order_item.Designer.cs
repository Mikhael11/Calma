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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.combocatg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Reportbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
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
            "BITES"});
            this.combocatg.Location = new System.Drawing.Point(19, 109);
            this.combocatg.Name = "combocatg";
            this.combocatg.Size = new System.Drawing.Size(207, 36);
            this.combocatg.TabIndex = 1;
            this.combocatg.SelectedIndexChanged += new System.EventHandler(this.combocatg_SelectedIndexChanged);
            // 
            // txtSrch
            // 
            this.txtSrch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSrch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtSrch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSrch.Location = new System.Drawing.Point(19, 173);
            this.txtSrch.Multiline = true;
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.PlaceholderText = "Search";
            this.txtSrch.Size = new System.Drawing.Size(207, 31);
            this.txtSrch.TabIndex = 2;
            this.txtSrch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSrch.TextChanged += new System.EventHandler(this.txtSrch_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 524);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(374, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Make an Order";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel1.Location = new System.Drawing.Point(261, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 212);
            this.panel1.TabIndex = 5;
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
            this.btnCard.Location = new System.Drawing.Point(474, 125);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(199, 56);
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
            this.texttotalorder.Location = new System.Drawing.Point(264, 148);
            this.texttotalorder.Multiline = true;
            this.texttotalorder.Name = "texttotalorder";
            this.texttotalorder.ReadOnly = true;
            this.texttotalorder.Size = new System.Drawing.Size(175, 32);
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
            this.textpriceorder.Location = new System.Drawing.Point(264, 53);
            this.textpriceorder.Multiline = true;
            this.textpriceorder.Name = "textpriceorder";
            this.textpriceorder.Size = new System.Drawing.Size(175, 31);
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
            this.textnameorder.Location = new System.Drawing.Point(22, 53);
            this.textnameorder.Multiline = true;
            this.textnameorder.Name = "textnameorder";
            this.textnameorder.ReadOnly = true;
            this.textnameorder.Size = new System.Drawing.Size(191, 31);
            this.textnameorder.TabIndex = 6;
            this.textnameorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numorder
            // 
            this.numorder.BackColor = System.Drawing.Color.Transparent;
            this.numorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numorder.Location = new System.Drawing.Point(22, 148);
            this.numorder.Name = "numorder";
            this.numorder.Size = new System.Drawing.Size(192, 33);
            this.numorder.TabIndex = 10;
            this.numorder.ValueChanged += new System.EventHandler(this.numorder_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(263, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(263, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
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
            this.Rmvdata.Location = new System.Drawing.Point(261, 679);
            this.Rmvdata.Name = "Rmvdata";
            this.Rmvdata.Size = new System.Drawing.Size(202, 56);
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
            this.Print.Location = new System.Drawing.Point(739, 679);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(202, 56);
            this.Print.TabIndex = 15;
            this.Print.Text = "Etb3 ya ma3lem";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(771, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalPrice.Location = new System.Drawing.Point(758, 619);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(137, 43);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 27;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Coloumn3,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(261, 331);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 29;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(675, 241);
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
            this.txtService.Location = new System.Drawing.Point(527, 619);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(137, 43);
            this.txtService.TabIndex = 18;
            this.txtService.Text = "LE";
            this.txtService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtService.Click += new System.EventHandler(this.txtService_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(541, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "service";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(363, 619);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 43);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.Text = "LE";
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(377, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 27);
            this.label11.TabIndex = 19;
            this.label11.Text = "Price";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Reportbtn
            // 
            this.Reportbtn.BorderRadius = 26;
            this.Reportbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reportbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reportbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reportbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reportbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(71)))), ((int)(((byte)(41)))));
            this.Reportbtn.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reportbtn.ForeColor = System.Drawing.Color.White;
            this.Reportbtn.Location = new System.Drawing.Point(500, 679);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(202, 56);
            this.Reportbtn.TabIndex = 21;
            this.Reportbtn.Text = "Report";
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // Order_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.Reportbtn);
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
            this.Name = "Order_item";
            this.Size = new System.Drawing.Size(974, 773);
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
        private Guna.UI2.WinForms.Guna2Button Reportbtn;
    }
}
