namespace WindowsFormsApp1
{
    partial class Rantal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label = new System.Windows.Forms.Label();
            this.nametxtx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Carsrentgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Rentadate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.retuenadate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblcarreg = new System.Windows.Forms.Label();
            this.custidlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.carregcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.custidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Carsrentgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(963, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 37);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cars On Rent";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Deletebtn.Animated = true;
            this.Deletebtn.BackColor = System.Drawing.Color.Black;
            this.Deletebtn.BorderRadius = 10;
            this.Deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.Deletebtn.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(341, 623);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(171, 59);
            this.Deletebtn.TabIndex = 69;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Updatebtn.Animated = true;
            this.Updatebtn.BackColor = System.Drawing.Color.Black;
            this.Updatebtn.BorderRadius = 10;
            this.Updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Updatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.Updatebtn.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(165, 623);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(162, 59);
            this.Updatebtn.TabIndex = 70;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addbtn.Animated = true;
            this.addbtn.BackColor = System.Drawing.Color.Black;
            this.addbtn.BorderRadius = 10;
            this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.addbtn.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(27, 623);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(121, 59);
            this.addbtn.TabIndex = 71;
            this.addbtn.Text = "ADD";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label.Location = new System.Drawing.Point(30, 250);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 37);
            this.label.TabIndex = 68;
            this.label.Text = "Name";
            // 
            // nametxtx
            // 
            this.nametxtx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nametxtx.Animated = true;
            this.nametxtx.AutoRoundedCorners = true;
            this.nametxtx.BorderRadius = 26;
            this.nametxtx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxtx.DefaultText = "";
            this.nametxtx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametxtx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametxtx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxtx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxtx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.nametxtx.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.nametxtx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.nametxtx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.nametxtx.IconLeftSize = new System.Drawing.Size(0, 0);
            this.nametxtx.IconRightSize = new System.Drawing.Size(0, 0);
            this.nametxtx.Location = new System.Drawing.Point(252, 233);
            this.nametxtx.Margin = new System.Windows.Forms.Padding(0);
            this.nametxtx.Name = "nametxtx";
            this.nametxtx.PasswordChar = '\0';
            this.nametxtx.PlaceholderText = "";
            this.nametxtx.SelectedText = "";
            this.nametxtx.Size = new System.Drawing.Size(249, 54);
            this.nametxtx.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "CarReg";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 37);
            this.label5.TabIndex = 63;
            this.label5.Text = "Customer ID";
            // 
            // Carsrentgridview
            // 
            this.Carsrentgridview.AllowUserToAddRows = false;
            this.Carsrentgridview.AllowUserToDeleteRows = false;
            this.Carsrentgridview.AllowUserToResizeColumns = false;
            this.Carsrentgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Carsrentgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Carsrentgridview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Carsrentgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Carsrentgridview.ColumnHeadersHeight = 40;
            this.Carsrentgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Carsrentgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Carsrentgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Carsrentgridview.Location = new System.Drawing.Point(585, 84);
            this.Carsrentgridview.Name = "Carsrentgridview";
            this.Carsrentgridview.ReadOnly = true;
            this.Carsrentgridview.RowHeadersVisible = false;
            this.Carsrentgridview.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carsrentgridview.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Carsrentgridview.RowTemplate.Height = 28;
            this.Carsrentgridview.Size = new System.Drawing.Size(988, 532);
            this.Carsrentgridview.TabIndex = 77;
            this.Carsrentgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Carsrentgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Carsrentgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Carsrentgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Carsrentgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Carsrentgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Carsrentgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Carsrentgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Carsrentgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Carsrentgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carsrentgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Carsrentgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Carsrentgridview.ThemeStyle.HeaderStyle.Height = 40;
            this.Carsrentgridview.ThemeStyle.ReadOnly = true;
            this.Carsrentgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Carsrentgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Carsrentgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carsrentgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Carsrentgridview.ThemeStyle.RowsStyle.Height = 28;
            this.Carsrentgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Carsrentgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Carsrentgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Carsrentgridview_CellContentClick);
            // 
            // Rentadate
            // 
            this.Rentadate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Rentadate.BorderRadius = 15;
            this.Rentadate.Checked = true;
            this.Rentadate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.Rentadate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Rentadate.ForeColor = System.Drawing.Color.White;
            this.Rentadate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Rentadate.Location = new System.Drawing.Point(261, 328);
            this.Rentadate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Rentadate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Rentadate.Name = "Rentadate";
            this.Rentadate.Size = new System.Drawing.Size(284, 45);
            this.Rentadate.TabIndex = 78;
            this.Rentadate.Value = new System.DateTime(2024, 5, 3, 9, 58, 14, 879);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(30, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 68;
            this.label2.Text = "Rent Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(30, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 37);
            this.label3.TabIndex = 68;
            this.label3.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(30, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 37);
            this.label6.TabIndex = 68;
            this.label6.Text = "Price";
            // 
            // pricetxt
            // 
            this.pricetxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pricetxt.Animated = true;
            this.pricetxt.AutoRoundedCorners = true;
            this.pricetxt.BorderRadius = 26;
            this.pricetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricetxt.DefaultText = "";
            this.pricetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pricetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pricetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pricetxt.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pricetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pricetxt.IconLeftSize = new System.Drawing.Size(0, 0);
            this.pricetxt.IconRightSize = new System.Drawing.Size(0, 0);
            this.pricetxt.Location = new System.Drawing.Point(257, 482);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(0);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.PasswordChar = '\0';
            this.pricetxt.PlaceholderText = "";
            this.pricetxt.SelectedText = "";
            this.pricetxt.Size = new System.Drawing.Size(249, 54);
            this.pricetxt.TabIndex = 65;
            this.pricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceValid);
            // 
            // retuenadate
            // 
            this.retuenadate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.retuenadate.BorderRadius = 15;
            this.retuenadate.Checked = true;
            this.retuenadate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.retuenadate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.retuenadate.ForeColor = System.Drawing.Color.White;
            this.retuenadate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.retuenadate.Location = new System.Drawing.Point(261, 402);
            this.retuenadate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.retuenadate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.retuenadate.Name = "retuenadate";
            this.retuenadate.Size = new System.Drawing.Size(284, 45);
            this.retuenadate.TabIndex = 78;
            this.retuenadate.Value = new System.DateTime(2024, 5, 3, 9, 58, 14, 879);
            // 
            // lblcarreg
            // 
            this.lblcarreg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblcarreg.AutoSize = true;
            this.lblcarreg.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.lblcarreg.Location = new System.Drawing.Point(273, 114);
            this.lblcarreg.Name = "lblcarreg";
            this.lblcarreg.Size = new System.Drawing.Size(0, 26);
            this.lblcarreg.TabIndex = 79;
            // 
            // custidlbl
            // 
            this.custidlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.custidlbl.AutoSize = true;
            this.custidlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custidlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.custidlbl.Location = new System.Drawing.Point(273, 204);
            this.custidlbl.Name = "custidlbl";
            this.custidlbl.Size = new System.Drawing.Size(0, 26);
            this.custidlbl.TabIndex = 79;
            // 
            // namelbl
            // 
            this.namelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.namelbl.Location = new System.Drawing.Point(273, 292);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(0, 26);
            this.namelbl.TabIndex = 79;
            // 
            // pricelbl
            // 
            this.pricelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pricelbl.Location = new System.Drawing.Point(273, 541);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(0, 26);
            this.pricelbl.TabIndex = 79;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // carregcombo
            // 
            this.carregcombo.AllowDrop = true;
            this.carregcombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.carregcombo.AutoRoundedCorners = true;
            this.carregcombo.BackColor = System.Drawing.Color.Transparent;
            this.carregcombo.BorderRadius = 17;
            this.carregcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carregcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carregcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carregcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carregcombo.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.carregcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.carregcombo.ItemHeight = 30;
            this.carregcombo.Location = new System.Drawing.Point(261, 56);
            this.carregcombo.Name = "carregcombo";
            this.carregcombo.Size = new System.Drawing.Size(249, 36);
            this.carregcombo.TabIndex = 80;
            // 
            // custidcombo
            // 
            this.custidcombo.AllowDrop = true;
            this.custidcombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.custidcombo.AutoRoundedCorners = true;
            this.custidcombo.BackColor = System.Drawing.Color.Transparent;
            this.custidcombo.BorderRadius = 17;
            this.custidcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.custidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custidcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.custidcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.custidcombo.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.custidcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.custidcombo.ItemHeight = 30;
            this.custidcombo.Location = new System.Drawing.Point(261, 150);
            this.custidcombo.Name = "custidcombo";
            this.custidcombo.Size = new System.Drawing.Size(249, 36);
            this.custidcombo.TabIndex = 81;
            this.custidcombo.SelectedIndexChanged += new System.EventHandler(this.ChangeNameOfCust);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(209, 725);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 82;
            this.label7.Text = "clear";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Rantal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1572, 793);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.custidcombo);
            this.Controls.Add(this.carregcombo);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.custidlbl);
            this.Controls.Add(this.lblcarreg);
            this.Controls.Add(this.retuenadate);
            this.Controls.Add(this.Rentadate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.nametxtx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Carsrentgridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rantal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Rantal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carsrentgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox nametxtx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView Carsrentgridview;
        private Guna.UI2.WinForms.Guna2DateTimePicker Rentadate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox pricetxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker retuenadate;
        private System.Windows.Forms.Label lblcarreg;
        private System.Windows.Forms.Label custidlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pricelbl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox custidcombo;
        private Guna.UI2.WinForms.Guna2ComboBox carregcombo;
        private System.Windows.Forms.Label label7;
    }
}