namespace EVSoft.HRMS.UI.BHXH
{
    partial class frmListEmployeeInsurance
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
            this.pnDepartment = new System.Windows.Forms.Panel();
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.btnDeletedEmployee = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.pnEmployee = new System.Windows.Forms.Panel();
            this.lvwEmployee = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cDepartmentName = new XPTable.Models.TextColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.cGender = new XPTable.Models.TextColumn();
            this.cDateOfBirth = new XPTable.Models.TextColumn();
            this.cIdentityCard = new XPTable.Models.TextColumn();
            this.cPhone = new XPTable.Models.TextColumn();
            this.cTrinhdo = new XPTable.Models.TextColumn();
            this.cAddress = new XPTable.Models.TextColumn();
            this.cCommune = new XPTable.Models.TextColumn();
            this.cDistrict = new XPTable.Models.TextColumn();
            this.cProvince = new XPTable.Models.TextColumn();
            this.cPosition = new XPTable.Models.TextColumn();
            this.cStartTrial = new XPTable.Models.TextColumn();
            this.cStartDate = new XPTable.Models.TextColumn();
            this.cBasicSalary = new XPTable.Models.NumberColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPermanentDelete = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnDepartment.SuspendLayout();
            this.pnEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployee)).BeginInit();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDepartment
            // 
            this.pnDepartment.Controls.Add(this.departmentTreeView);
            this.pnDepartment.Controls.Add(this.btnDeletedEmployee);
            this.pnDepartment.Controls.Add(this.lblDepartment);
            this.pnDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDepartment.Location = new System.Drawing.Point(0, 0);
            this.pnDepartment.Name = "pnDepartment";
            this.pnDepartment.Size = new System.Drawing.Size(200, 550);
            this.pnDepartment.TabIndex = 0;
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeView.BackColor = System.Drawing.Color.GhostWhite;
            this.departmentTreeView.DepartmentDataSet = null;
            this.departmentTreeView.ImageIndex = 0;
            this.departmentTreeView.Location = new System.Drawing.Point(0, 24);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.SelectedImageIndex = 0;
            this.departmentTreeView.Size = new System.Drawing.Size(200, 504);
            this.departmentTreeView.TabIndex = 5;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // btnDeletedEmployee
            // 
            this.btnDeletedEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeletedEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletedEmployee.Location = new System.Drawing.Point(0, 527);
            this.btnDeletedEmployee.Name = "btnDeletedEmployee";
            this.btnDeletedEmployee.Size = new System.Drawing.Size(200, 23);
            this.btnDeletedEmployee.TabIndex = 7;
            this.btnDeletedEmployee.Text = "Danh sách nhân viên đã xóa";
            this.btnDeletedEmployee.Click += new System.EventHandler(this.btnDeletedEmployee_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartment.Location = new System.Drawing.Point(0, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(200, 24);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Danh sách các đơn vị";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnEmployee
            // 
            this.pnEmployee.Controls.Add(this.lvwEmployee);
            this.pnEmployee.Controls.Add(this.lblEmployee);
            this.pnEmployee.Controls.Add(this.pnButtons);
            this.pnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmployee.Location = new System.Drawing.Point(200, 0);
            this.pnEmployee.Name = "pnEmployee";
            this.pnEmployee.Size = new System.Drawing.Size(648, 550);
            this.pnEmployee.TabIndex = 4;
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwEmployee.ColumnModel = this.columnModel1;
            this.lvwEmployee.EnableHeaderContextMenu = false;
            this.lvwEmployee.EnableToolTips = true;
            this.lvwEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployee.FullRowSelect = true;
            this.lvwEmployee.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwEmployee.GridLines = XPTable.Models.GridLines.Both;
            this.lvwEmployee.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwEmployee.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwEmployee.Location = new System.Drawing.Point(8, 24);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwEmployee.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployee.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwEmployee.Size = new System.Drawing.Size(640, 488);
            this.lvwEmployee.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwEmployee.TabIndex = 10;
            this.lvwEmployee.TableModel = this.tableModel1;
            this.lvwEmployee.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwEmployee.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwEmployee_KeyPress);
            this.lvwEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwEmployee_MouseDown);
            this.lvwEmployee.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwEmployee_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cDepartmentName,
            this.cCardID,
            this.cEmployeeName,
            this.cGender,
            this.cDateOfBirth,
            this.cIdentityCard,
            this.cPhone,
            this.cTrinhdo,
            this.cAddress,
            this.cCommune,
            this.cDistrict,
            this.cProvince,
            this.cPosition,
            this.cStartTrial,
            this.cStartDate,
            this.cBasicSalary});
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cSTT.Text = "STT";
            this.cSTT.Width = 40;
            // 
            // cDepartmentName
            // 
            this.cDepartmentName.Editable = false;
            this.cDepartmentName.Text = "Bộ phận";
            this.cDepartmentName.Width = 90;
            // 
            // cCardID
            // 
            this.cCardID.Editable = false;
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 50;
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Editable = false;
            this.cEmployeeName.Text = "Tên nhân viên";
            this.cEmployeeName.Width = 130;
            // 
            // cGender
            // 
            this.cGender.Editable = false;
            this.cGender.Text = "Giới tính";
            this.cGender.Width = 60;
            // 
            // cDateOfBirth
            // 
            this.cDateOfBirth.Editable = false;
            this.cDateOfBirth.Text = "Ngày sinh";
            // 
            // cIdentityCard
            // 
            this.cIdentityCard.Editable = false;
            this.cIdentityCard.Text = "Số CMND";
            // 
            // cPhone
            // 
            this.cPhone.Editable = false;
            this.cPhone.Text = "Điện thoại";
            // 
            // cTrinhdo
            // 
            this.cTrinhdo.Editable = false;
            this.cTrinhdo.Text = "Trình độ";
            this.cTrinhdo.Width = 58;
            // 
            // cAddress
            // 
            this.cAddress.Editable = false;
            this.cAddress.Text = "Địa chỉ";
            this.cAddress.Width = 100;
            // 
            // cCommune
            // 
            this.cCommune.Editable = false;
            this.cCommune.Text = "Phường/xã";
            this.cCommune.Width = 80;
            // 
            // cDistrict
            // 
            this.cDistrict.Editable = false;
            this.cDistrict.Text = "Quận/huyện";
            this.cDistrict.Width = 80;
            // 
            // cProvince
            // 
            this.cProvince.Text = "Tỉnh/T.phố";
            this.cProvince.Width = 80;
            // 
            // cPosition
            // 
            this.cPosition.Editable = false;
            this.cPosition.Text = "Chức vụ";
            this.cPosition.Width = 62;
            // 
            // cStartTrial
            // 
            this.cStartTrial.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cStartTrial.Editable = false;
            this.cStartTrial.Text = "Ngày thử việc";
            this.cStartTrial.Width = 91;
            // 
            // cStartDate
            // 
            this.cStartDate.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cStartDate.Text = "Ngày chính thức";
            this.cStartDate.Width = 98;
            // 
            // cBasicSalary
            // 
            this.cBasicSalary.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cBasicSalary.Editable = false;
            this.cBasicSalary.Format = "#,##0;(#,##0);-";
            this.cBasicSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cBasicSalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cBasicSalary.Text = "Lương cơ bản";
            this.cBasicSalary.Width = 84;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployee.Location = new System.Drawing.Point(8, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(640, 24);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Tổng số nhân viên trong danh sách: 999";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnClose);
            this.pnButtons.Controls.Add(this.btnSearch);
            this.pnButtons.Controls.Add(this.txtSearch);
            this.pnButtons.Controls.Add(this.btnExcel);
            this.pnButtons.Controls.Add(this.btnPermanentDelete);
            this.pnButtons.Controls.Add(this.btnRestore);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 510);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(648, 40);
            this.pnButtons.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(568, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(129, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(16, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(377, 8);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "In báo cáo";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPermanentDelete
            // 
            this.btnPermanentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPermanentDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPermanentDelete.Location = new System.Drawing.Point(487, 8);
            this.btnPermanentDelete.Name = "btnPermanentDelete";
            this.btnPermanentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPermanentDelete.TabIndex = 9;
            this.btnPermanentDelete.Text = "&Xóa";
            this.btnPermanentDelete.Click += new System.EventHandler(this.btnPermanentDelete_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Location = new System.Drawing.Point(487, 8);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "&Khôi phục";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 550);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // frmListEmployeeInsurance
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(848, 550);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnEmployee);
            this.Controls.Add(this.pnDepartment);
            this.Name = "frmListEmployeeInsurance";
            this.Text = "Danh sách nhân viên đề nghị cấp sổ BHXH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListEmployees_Load);
            this.pnDepartment.ResumeLayout(false);
            this.pnEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployee)).EndInit();
            this.pnButtons.ResumeLayout(false);
            this.pnButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}