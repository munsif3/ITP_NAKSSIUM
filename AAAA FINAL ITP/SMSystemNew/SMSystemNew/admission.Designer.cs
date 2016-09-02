namespace SMSystemNew
{
    partial class admission
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.Btnupdateadmission = new MetroFramework.Controls.MetroButton();
            this.View_admission = new MetroFramework.Controls.MetroButton();
            this.keyApplication = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGridAdmission = new MetroFramework.Controls.MetroGrid();
            this.admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtinterviewdate = new MetroFramework.Controls.MetroTextBox();
            this.txtapplieddate = new MetroFramework.Controls.MetroTextBox();
            this.RadNotselected = new MetroFramework.Controls.MetroRadioButton();
            this.radSelected = new MetroFramework.Controls.MetroRadioButton();
            this.txtsurname = new MetroFramework.Controls.MetroTextBox();
            this.txtstudentname = new MetroFramework.Controls.MetroTextBox();
            this.txtapplicationno = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sudheesanDataSet = new SMSystemNew.sudheesanDataSet();
            this.admissionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.admissionTableAdapter = new SMSystemNew.sudheesanDataSetTableAdapters.admissionTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAdmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sudheesanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton5);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.Btnupdateadmission);
            this.metroPanel1.Controls.Add(this.View_admission);
            this.metroPanel1.Controls.Add(this.keyApplication);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 69);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(657, 40);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.Text = "REFRESH";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(576, 41);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "DELETE";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Btnupdateadmission
            // 
            this.Btnupdateadmission.Location = new System.Drawing.Point(493, 40);
            this.Btnupdateadmission.Name = "Btnupdateadmission";
            this.Btnupdateadmission.Size = new System.Drawing.Size(75, 23);
            this.Btnupdateadmission.TabIndex = 5;
            this.Btnupdateadmission.Text = "UPDATE";
            this.Btnupdateadmission.UseSelectable = true;
            this.Btnupdateadmission.Click += new System.EventHandler(this.Btnupdateadmission_Click);
            // 
            // View_admission
            // 
            this.View_admission.Location = new System.Drawing.Point(412, 40);
            this.View_admission.Name = "View_admission";
            this.View_admission.Size = new System.Drawing.Size(75, 23);
            this.View_admission.TabIndex = 4;
            this.View_admission.Text = "VIEW";
            this.View_admission.UseSelectable = true;
            this.View_admission.Click += new System.EventHandler(this.View_admission_Click);
            // 
            // keyApplication
            // 
            // 
            // 
            // 
            this.keyApplication.CustomButton.Image = null;
            this.keyApplication.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.keyApplication.CustomButton.Name = "";
            this.keyApplication.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keyApplication.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyApplication.CustomButton.TabIndex = 1;
            this.keyApplication.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyApplication.CustomButton.UseSelectable = true;
            this.keyApplication.CustomButton.Visible = false;
            this.keyApplication.Lines = new string[0];
            this.keyApplication.Location = new System.Drawing.Point(178, 10);
            this.keyApplication.MaxLength = 32767;
            this.keyApplication.Name = "keyApplication";
            this.keyApplication.PasswordChar = '\0';
            this.keyApplication.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyApplication.SelectedText = "";
            this.keyApplication.SelectionLength = 0;
            this.keyApplication.SelectionStart = 0;
            this.keyApplication.Size = new System.Drawing.Size(141, 23);
            this.keyApplication.TabIndex = 3;
            this.keyApplication.UseSelectable = true;
            this.keyApplication.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyApplication.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Application Number";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroGridAdmission);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 129);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(760, 160);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGridAdmission
            // 
            this.metroGridAdmission.AllowUserToAddRows = false;
            this.metroGridAdmission.AllowUserToDeleteRows = false;
            this.metroGridAdmission.AllowUserToResizeRows = false;
            this.metroGridAdmission.AutoGenerateColumns = false;
            this.metroGridAdmission.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAdmission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAdmission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAdmission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAdmission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAdmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridAdmission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.metroGridAdmission.DataSource = this.admissionBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAdmission.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAdmission.EnableHeadersVisualStyles = false;
            this.metroGridAdmission.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAdmission.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAdmission.Location = new System.Drawing.Point(15, 10);
            this.metroGridAdmission.Name = "metroGridAdmission";
            this.metroGridAdmission.ReadOnly = true;
            this.metroGridAdmission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAdmission.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAdmission.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAdmission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAdmission.Size = new System.Drawing.Size(663, 122);
            this.metroGridAdmission.TabIndex = 2;
            // 
            // admissionBindingSource
            // 
            this.admissionBindingSource.DataMember = "admission";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.txtinterviewdate);
            this.metroPanel3.Controls.Add(this.txtapplieddate);
            this.metroPanel3.Controls.Add(this.RadNotselected);
            this.metroPanel3.Controls.Add(this.radSelected);
            this.metroPanel3.Controls.Add(this.txtsurname);
            this.metroPanel3.Controls.Add(this.txtstudentname);
            this.metroPanel3.Controls.Add(this.txtapplicationno);
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 267);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(760, 310);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtinterviewdate
            // 
            // 
            // 
            // 
            this.txtinterviewdate.CustomButton.Image = null;
            this.txtinterviewdate.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtinterviewdate.CustomButton.Name = "";
            this.txtinterviewdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtinterviewdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtinterviewdate.CustomButton.TabIndex = 1;
            this.txtinterviewdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtinterviewdate.CustomButton.UseSelectable = true;
            this.txtinterviewdate.CustomButton.Visible = false;
            this.txtinterviewdate.Lines = new string[0];
            this.txtinterviewdate.Location = new System.Drawing.Point(178, 169);
            this.txtinterviewdate.MaxLength = 32767;
            this.txtinterviewdate.Name = "txtinterviewdate";
            this.txtinterviewdate.PasswordChar = '\0';
            this.txtinterviewdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtinterviewdate.SelectedText = "";
            this.txtinterviewdate.SelectionLength = 0;
            this.txtinterviewdate.SelectionStart = 0;
            this.txtinterviewdate.Size = new System.Drawing.Size(200, 23);
            this.txtinterviewdate.TabIndex = 22;
            this.txtinterviewdate.UseSelectable = true;
            this.txtinterviewdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtinterviewdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtapplieddate
            // 
            // 
            // 
            // 
            this.txtapplieddate.CustomButton.Image = null;
            this.txtapplieddate.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtapplieddate.CustomButton.Name = "";
            this.txtapplieddate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtapplieddate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtapplieddate.CustomButton.TabIndex = 1;
            this.txtapplieddate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtapplieddate.CustomButton.UseSelectable = true;
            this.txtapplieddate.CustomButton.Visible = false;
            this.txtapplieddate.Lines = new string[0];
            this.txtapplieddate.Location = new System.Drawing.Point(178, 130);
            this.txtapplieddate.MaxLength = 32767;
            this.txtapplieddate.Name = "txtapplieddate";
            this.txtapplieddate.PasswordChar = '\0';
            this.txtapplieddate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtapplieddate.SelectedText = "";
            this.txtapplieddate.SelectionLength = 0;
            this.txtapplieddate.SelectionStart = 0;
            this.txtapplieddate.Size = new System.Drawing.Size(200, 23);
            this.txtapplieddate.TabIndex = 21;
            this.txtapplieddate.UseSelectable = true;
            this.txtapplieddate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtapplieddate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RadNotselected
            // 
            this.RadNotselected.AutoSize = true;
            this.RadNotselected.Location = new System.Drawing.Point(268, 215);
            this.RadNotselected.Name = "RadNotselected";
            this.RadNotselected.Size = new System.Drawing.Size(90, 15);
            this.RadNotselected.TabIndex = 20;
            this.RadNotselected.Text = "Not Selected";
            this.RadNotselected.UseSelectable = true;
            // 
            // radSelected
            // 
            this.radSelected.AutoSize = true;
            this.radSelected.Location = new System.Drawing.Point(178, 215);
            this.radSelected.Name = "radSelected";
            this.radSelected.Size = new System.Drawing.Size(67, 15);
            this.radSelected.TabIndex = 19;
            this.radSelected.Text = "Selected";
            this.radSelected.UseSelectable = true;
            // 
            // txtsurname
            // 
            // 
            // 
            // 
            this.txtsurname.CustomButton.Image = null;
            this.txtsurname.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtsurname.CustomButton.Name = "";
            this.txtsurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsurname.CustomButton.TabIndex = 1;
            this.txtsurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsurname.CustomButton.UseSelectable = true;
            this.txtsurname.CustomButton.Visible = false;
            this.txtsurname.Lines = new string[0];
            this.txtsurname.Location = new System.Drawing.Point(178, 91);
            this.txtsurname.MaxLength = 32767;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.PasswordChar = '\0';
            this.txtsurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsurname.SelectedText = "";
            this.txtsurname.SelectionLength = 0;
            this.txtsurname.SelectionStart = 0;
            this.txtsurname.Size = new System.Drawing.Size(200, 23);
            this.txtsurname.TabIndex = 16;
            this.txtsurname.UseSelectable = true;
            this.txtsurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtstudentname
            // 
            // 
            // 
            // 
            this.txtstudentname.CustomButton.Image = null;
            this.txtstudentname.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtstudentname.CustomButton.Name = "";
            this.txtstudentname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtstudentname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstudentname.CustomButton.TabIndex = 1;
            this.txtstudentname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstudentname.CustomButton.UseSelectable = true;
            this.txtstudentname.CustomButton.Visible = false;
            this.txtstudentname.Lines = new string[0];
            this.txtstudentname.Location = new System.Drawing.Point(178, 56);
            this.txtstudentname.MaxLength = 32767;
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.PasswordChar = '\0';
            this.txtstudentname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstudentname.SelectedText = "";
            this.txtstudentname.SelectionLength = 0;
            this.txtstudentname.SelectionStart = 0;
            this.txtstudentname.Size = new System.Drawing.Size(200, 23);
            this.txtstudentname.TabIndex = 15;
            this.txtstudentname.UseSelectable = true;
            this.txtstudentname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstudentname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtapplicationno
            // 
            // 
            // 
            // 
            this.txtapplicationno.CustomButton.Image = null;
            this.txtapplicationno.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtapplicationno.CustomButton.Name = "";
            this.txtapplicationno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtapplicationno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtapplicationno.CustomButton.TabIndex = 1;
            this.txtapplicationno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtapplicationno.CustomButton.UseSelectable = true;
            this.txtapplicationno.CustomButton.Visible = false;
            this.txtapplicationno.Lines = new string[0];
            this.txtapplicationno.Location = new System.Drawing.Point(178, 22);
            this.txtapplicationno.MaxLength = 32767;
            this.txtapplicationno.Name = "txtapplicationno";
            this.txtapplicationno.PasswordChar = '\0';
            this.txtapplicationno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtapplicationno.SelectedText = "";
            this.txtapplicationno.SelectionLength = 0;
            this.txtapplicationno.SelectionStart = 0;
            this.txtapplicationno.Size = new System.Drawing.Size(200, 23);
            this.txtapplicationno.TabIndex = 14;
            this.txtapplicationno.UseSelectable = true;
            this.txtapplicationno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtapplicationno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroButton3);
            this.metroPanel4.Controls.Add(this.metroButton1);
            this.metroPanel4.Controls.Add(this.metroButton2);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(477, 235);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(280, 72);
            this.metroPanel4.TabIndex = 13;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            this.metroPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel4_Paint);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(193, 25);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(76, 33);
            this.metroButton3.TabIndex = 11;
            this.metroButton3.Text = "EXIT";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 25);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(76, 33);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "ADD";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(103, 25);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(76, 33);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "CLEAR";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(22, 211);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Interview Status";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(22, 172);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Interview Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 134);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Appplied Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 97);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Surname";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Student Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Application Number";
            // 
            // sudheesanDataSet
            // 
            this.sudheesanDataSet.DataSetName = "sudheesanDataSet";
            this.sudheesanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admissionBindingSource1
            // 
            this.admissionBindingSource1.DataMember = "admission";
            this.admissionBindingSource1.DataSource = this.sudheesanDataSet;
            // 
            // admissionTableAdapter
            // 
            this.admissionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "application_no";
            this.dataGridViewTextBoxColumn1.HeaderText = "application_no";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "applied_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "applied_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "interview_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "interview_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "interview_status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "interview_status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "admission";
            this.Text = "Admission";
            this.Load += new System.EventHandler(this.admission_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAdmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sudheesanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox keyApplication;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton RadNotselected;
        private MetroFramework.Controls.MetroRadioButton radSelected;
        private MetroFramework.Controls.MetroTextBox txtsurname;
        private MetroFramework.Controls.MetroTextBox txtstudentname;
        private MetroFramework.Controls.MetroTextBox txtapplicationno;
        private MetroFramework.Controls.MetroGrid metroGridAdmission;

        private System.Windows.Forms.BindingSource admissionBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applieddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interviewdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn interviewstatusDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroButton View_admission;
        private MetroFramework.Controls.MetroButton Btnupdateadmission;
        private MetroFramework.Controls.MetroTextBox txtinterviewdate;
        private MetroFramework.Controls.MetroTextBox txtapplieddate;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private sudheesanDataSet sudheesanDataSet;
        private System.Windows.Forms.BindingSource admissionBindingSource1;
        private sudheesanDataSetTableAdapters.admissionTableAdapter admissionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}