
namespace AlzaStockCheck
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_CardType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_Info = new System.Windows.Forms.Label();
            this.gb_Manufacturer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cb_PNY = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_Palit = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_Inno3d = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_Gainward = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_MSI = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_Gigabyte = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_Asus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_Evga = new Guna.UI2.WinForms.Guna2CheckBox();
            this.refreshClockTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_Info2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.gb_Manufacturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.productDataGridView.ColumnHeadersHeight = 21;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.price,
            this.availability});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGridView.EnableHeadersVisualStyles = false;
            this.productDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDataGridView.Location = new System.Drawing.Point(12, 174);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(831, 460);
            this.productDataGridView.TabIndex = 0;
            this.productDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.productDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.productDataGridView.ThemeStyle.ReadOnly = false;
            this.productDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.productDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellDoubleClick);
            // 
            // productName
            // 
            this.productName.HeaderText = "Název Produktu";
            this.productName.Name = "productName";
            // 
            // price
            // 
            this.price.HeaderText = "Cena";
            this.price.Name = "price";
            // 
            // availability
            // 
            this.availability.HeaderText = "Dostupnost";
            this.availability.Name = "availability";
            // 
            // cb_CardType
            // 
            this.cb_CardType.BackColor = System.Drawing.Color.Transparent;
            this.cb_CardType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CardType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CardType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CardType.FocusedState.Parent = this.cb_CardType;
            this.cb_CardType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_CardType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_CardType.HoverState.Parent = this.cb_CardType;
            this.cb_CardType.ItemHeight = 30;
            this.cb_CardType.Items.AddRange(new object[] {
            "Všechny",
            "RTX 3090",
            "RTX 3080 Ti",
            "RTX 3080",
            "RTX 3070 Ti",
            "RTX 3070",
            "RTX 3060 Ti",
            "RTX 3060"});
            this.cb_CardType.ItemsAppearance.Parent = this.cb_CardType;
            this.cb_CardType.Location = new System.Drawing.Point(24, 13);
            this.cb_CardType.Name = "cb_CardType";
            this.cb_CardType.ShadowDecoration.Parent = this.cb_CardType;
            this.cb_CardType.Size = new System.Drawing.Size(197, 36);
            this.cb_CardType.StartIndex = 0;
            this.cb_CardType.TabIndex = 1;
            this.cb_CardType.SelectedIndexChanged += new System.EventHandler(this.cb_CardType_SelectedIndexChanged);
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Location = new System.Drawing.Point(319, 13);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(63, 13);
            this.lb_Info.TabIndex = 2;
            this.lb_Info.Text = "AAAAAAAA";
            // 
            // gb_Manufacturer
            // 
            this.gb_Manufacturer.Controls.Add(this.cb_PNY);
            this.gb_Manufacturer.Controls.Add(this.cb_Palit);
            this.gb_Manufacturer.Controls.Add(this.cb_Inno3d);
            this.gb_Manufacturer.Controls.Add(this.cb_Gainward);
            this.gb_Manufacturer.Controls.Add(this.cb_MSI);
            this.gb_Manufacturer.Controls.Add(this.cb_Gigabyte);
            this.gb_Manufacturer.Controls.Add(this.cb_Asus);
            this.gb_Manufacturer.Controls.Add(this.cb_Evga);
            this.gb_Manufacturer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_Manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb_Manufacturer.Location = new System.Drawing.Point(227, 13);
            this.gb_Manufacturer.Name = "gb_Manufacturer";
            this.gb_Manufacturer.ShadowDecoration.Parent = this.gb_Manufacturer;
            this.gb_Manufacturer.Size = new System.Drawing.Size(186, 140);
            this.gb_Manufacturer.TabIndex = 3;
            this.gb_Manufacturer.Text = "Výrobce";
            // 
            // cb_PNY
            // 
            this.cb_PNY.AutoSize = true;
            this.cb_PNY.BackColor = System.Drawing.SystemColors.Window;
            this.cb_PNY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_PNY.CheckedState.BorderRadius = 0;
            this.cb_PNY.CheckedState.BorderThickness = 0;
            this.cb_PNY.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_PNY.Location = new System.Drawing.Point(88, 117);
            this.cb_PNY.Name = "cb_PNY";
            this.cb_PNY.Size = new System.Drawing.Size(49, 19);
            this.cb_PNY.TabIndex = 0;
            this.cb_PNY.Text = "PNY";
            this.cb_PNY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_PNY.UncheckedState.BorderRadius = 0;
            this.cb_PNY.UncheckedState.BorderThickness = 0;
            this.cb_PNY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_PNY.UseVisualStyleBackColor = false;
            this.cb_PNY.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_Palit
            // 
            this.cb_Palit.AutoSize = true;
            this.cb_Palit.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Palit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Palit.CheckedState.BorderRadius = 0;
            this.cb_Palit.CheckedState.BorderThickness = 0;
            this.cb_Palit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Palit.Location = new System.Drawing.Point(88, 92);
            this.cb_Palit.Name = "cb_Palit";
            this.cb_Palit.Size = new System.Drawing.Size(49, 19);
            this.cb_Palit.TabIndex = 0;
            this.cb_Palit.Text = "Palit";
            this.cb_Palit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Palit.UncheckedState.BorderRadius = 0;
            this.cb_Palit.UncheckedState.BorderThickness = 0;
            this.cb_Palit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Palit.UseVisualStyleBackColor = false;
            this.cb_Palit.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_Inno3d
            // 
            this.cb_Inno3d.AutoSize = true;
            this.cb_Inno3d.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Inno3d.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Inno3d.CheckedState.BorderRadius = 0;
            this.cb_Inno3d.CheckedState.BorderThickness = 0;
            this.cb_Inno3d.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Inno3d.Location = new System.Drawing.Point(88, 67);
            this.cb_Inno3d.Name = "cb_Inno3d";
            this.cb_Inno3d.Size = new System.Drawing.Size(64, 19);
            this.cb_Inno3d.TabIndex = 0;
            this.cb_Inno3d.Text = "Inno3D";
            this.cb_Inno3d.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Inno3d.UncheckedState.BorderRadius = 0;
            this.cb_Inno3d.UncheckedState.BorderThickness = 0;
            this.cb_Inno3d.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Inno3d.UseVisualStyleBackColor = false;
            this.cb_Inno3d.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_Gainward
            // 
            this.cb_Gainward.AutoSize = true;
            this.cb_Gainward.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Gainward.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Gainward.CheckedState.BorderRadius = 0;
            this.cb_Gainward.CheckedState.BorderThickness = 0;
            this.cb_Gainward.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Gainward.Location = new System.Drawing.Point(88, 42);
            this.cb_Gainward.Name = "cb_Gainward";
            this.cb_Gainward.Size = new System.Drawing.Size(88, 19);
            this.cb_Gainward.TabIndex = 0;
            this.cb_Gainward.Text = "GAINWARD";
            this.cb_Gainward.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Gainward.UncheckedState.BorderRadius = 0;
            this.cb_Gainward.UncheckedState.BorderThickness = 0;
            this.cb_Gainward.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Gainward.UseVisualStyleBackColor = false;
            this.cb_Gainward.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_MSI
            // 
            this.cb_MSI.AutoSize = true;
            this.cb_MSI.BackColor = System.Drawing.SystemColors.Window;
            this.cb_MSI.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_MSI.CheckedState.BorderRadius = 0;
            this.cb_MSI.CheckedState.BorderThickness = 0;
            this.cb_MSI.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_MSI.Location = new System.Drawing.Point(3, 117);
            this.cb_MSI.Name = "cb_MSI";
            this.cb_MSI.Size = new System.Drawing.Size(46, 19);
            this.cb_MSI.TabIndex = 0;
            this.cb_MSI.Text = "MSI";
            this.cb_MSI.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_MSI.UncheckedState.BorderRadius = 0;
            this.cb_MSI.UncheckedState.BorderThickness = 0;
            this.cb_MSI.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_MSI.UseVisualStyleBackColor = false;
            this.cb_MSI.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_Gigabyte
            // 
            this.cb_Gigabyte.AutoSize = true;
            this.cb_Gigabyte.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Gigabyte.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Gigabyte.CheckedState.BorderRadius = 0;
            this.cb_Gigabyte.CheckedState.BorderThickness = 0;
            this.cb_Gigabyte.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Gigabyte.Location = new System.Drawing.Point(3, 92);
            this.cb_Gigabyte.Name = "cb_Gigabyte";
            this.cb_Gigabyte.Size = new System.Drawing.Size(79, 19);
            this.cb_Gigabyte.TabIndex = 0;
            this.cb_Gigabyte.Text = "GIGABYTE";
            this.cb_Gigabyte.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Gigabyte.UncheckedState.BorderRadius = 0;
            this.cb_Gigabyte.UncheckedState.BorderThickness = 0;
            this.cb_Gigabyte.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Gigabyte.UseVisualStyleBackColor = false;
            this.cb_Gigabyte.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_Asus
            // 
            this.cb_Asus.AutoSize = true;
            this.cb_Asus.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Asus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Asus.CheckedState.BorderRadius = 0;
            this.cb_Asus.CheckedState.BorderThickness = 0;
            this.cb_Asus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Asus.Location = new System.Drawing.Point(3, 67);
            this.cb_Asus.Name = "cb_Asus";
            this.cb_Asus.Size = new System.Drawing.Size(54, 19);
            this.cb_Asus.TabIndex = 0;
            this.cb_Asus.Text = "ASUS";
            this.cb_Asus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Asus.UncheckedState.BorderRadius = 0;
            this.cb_Asus.UncheckedState.BorderThickness = 0;
            this.cb_Asus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Asus.UseVisualStyleBackColor = false;
            this.cb_Asus.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // cb_Evga
            // 
            this.cb_Evga.AutoSize = true;
            this.cb_Evga.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Evga.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Evga.CheckedState.BorderRadius = 0;
            this.cb_Evga.CheckedState.BorderThickness = 0;
            this.cb_Evga.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Evga.Location = new System.Drawing.Point(3, 42);
            this.cb_Evga.Name = "cb_Evga";
            this.cb_Evga.Size = new System.Drawing.Size(55, 19);
            this.cb_Evga.TabIndex = 0;
            this.cb_Evga.Text = "EVGA";
            this.cb_Evga.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Evga.UncheckedState.BorderRadius = 0;
            this.cb_Evga.UncheckedState.BorderThickness = 0;
            this.cb_Evga.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Evga.UseVisualStyleBackColor = false;
            this.cb_Evga.CheckedChanged += new System.EventHandler(this.Manufacturer_Checkbox_Checked_Change);
            // 
            // refreshClockTimer
            // 
            this.refreshClockTimer.Enabled = true;
            this.refreshClockTimer.Interval = 20000;
            this.refreshClockTimer.Tick += new System.EventHandler(this.refreshClockTimer_Tick);
            // 
            // lb_Info2
            // 
            this.lb_Info2.BackColor = System.Drawing.Color.Transparent;
            this.lb_Info2.Location = new System.Drawing.Point(598, 13);
            this.lb_Info2.Name = "lb_Info2";
            this.lb_Info2.Size = new System.Drawing.Size(70, 15);
            this.lb_Info2.TabIndex = 4;
            this.lb_Info2.Text = "Getting data...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 646);
            this.Controls.Add(this.lb_Info2);
            this.Controls.Add(this.gb_Manufacturer);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.cb_CardType);
            this.Controls.Add(this.productDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.gb_Manufacturer.ResumeLayout(false);
            this.gb_Manufacturer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CardType;
        private System.Windows.Forms.Label lb_Info;
        private Guna.UI2.WinForms.Guna2GroupBox gb_Manufacturer;
        private Guna.UI2.WinForms.Guna2CheckBox cb_Evga;
        private Guna.UI2.WinForms.Guna2CheckBox cb_PNY;
        private Guna.UI2.WinForms.Guna2CheckBox cb_Palit;
        private Guna.UI2.WinForms.Guna2CheckBox cb_Inno3d;
        private Guna.UI2.WinForms.Guna2CheckBox cb_Gainward;
        private Guna.UI2.WinForms.Guna2CheckBox cb_MSI;
        private Guna.UI2.WinForms.Guna2CheckBox cb_Gigabyte;
        private Guna.UI2.WinForms.Guna2CheckBox cb_Asus;
        private System.Windows.Forms.Timer refreshClockTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_Info2;
    }
}

