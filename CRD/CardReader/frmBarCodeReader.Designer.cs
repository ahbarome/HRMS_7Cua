namespace CardReader
{
    partial class frmBarCodeReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarCodeReader));
            this.bntClose = new System.Windows.Forms.Button();
            this.mnuHide = new System.Windows.Forms.MenuItem();
            this.mnuShow = new System.Windows.Forms.MenuItem();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuStart = new System.Windows.Forms.MenuItem();
            this.mnuStop = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.txtBarCodeID = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tmrActiveBarcode = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.tmrUpdateMessage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntClose.Location = new System.Drawing.Point(240, 199);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(72, 24);
            this.bntClose.TabIndex = 36;
            this.bntClose.Text = "&Đóng";
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // mnuHide
            // 
            this.mnuHide.Index = 1;
            this.mnuHide.Text = "Hide";
            this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
            // 
            // mnuShow
            // 
            this.mnuShow.Index = 0;
            this.mnuShow.Text = "Show";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuShow,
            this.mnuHide,
            this.menuItem3,
            this.mnuStart,
            this.mnuStop,
            this.menuItem6,
            this.mnuExit});
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // mnuStart
            // 
            this.mnuStart.Index = 3;
            this.mnuStart.Text = "Start Service";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Index = 4;
            this.mnuStop.Text = "Stop Service";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 6;
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Chương trình đọc thẻ PPSwipe";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfig.Location = new System.Drawing.Point(160, 199);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(72, 24);
            this.btnConfig.TabIndex = 46;
            this.btnConfig.Text = "&Cấu hình";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblClock.Location = new System.Drawing.Point(8, 199);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(128, 24);
            this.lblClock.TabIndex = 35;
            // 
            // picEmployee
            // 
            this.picEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
            this.picEmployee.Location = new System.Drawing.Point(320, 47);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(152, 168);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 37;
            this.picEmployee.TabStop = false;
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployeeInfo.Location = new System.Drawing.Point(16, 7);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(440, 32);
            this.lblEmployeeInfo.TabIndex = 38;
            this.lblEmployeeInfo.Text = "Thông tin về nhân viên quẹt mã vạch";
            this.lblEmployeeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBarCodeID
            // 
            this.txtBarCodeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBarCodeID.Location = new System.Drawing.Point(136, 47);
            this.txtBarCodeID.MaxLength = 13;
            this.txtBarCodeID.Name = "txtBarCodeID";
            this.txtBarCodeID.Size = new System.Drawing.Size(176, 22);
            this.txtBarCodeID.TabIndex = 43;
            this.txtBarCodeID.TextChanged += new System.EventHandler(this.txtBarCodeID_TextChanged);
            this.txtBarCodeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCodeID_KeyDown);
            this.txtBarCodeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardID_KeyPress);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTime.Location = new System.Drawing.Point(136, 135);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(176, 30);
            this.lblTime.TabIndex = 42;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDepartment.Location = new System.Drawing.Point(136, 95);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(176, 22);
            this.txtDepartment.TabIndex = 45;
            this.txtDepartment.TabStop = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmployeeName.Location = new System.Drawing.Point(136, 71);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 22);
            this.txtEmployeeName.TabIndex = 44;
            this.txtEmployeeName.TabStop = false;
            // 
            // lblCardID
            // 
            this.lblCardID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCardID.Location = new System.Drawing.Point(10, 47);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(112, 24);
            this.lblCardID.TabIndex = 40;
            this.lblCardID.Text = "Mã vạch";
            this.lblCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrTimeUpdate
            // 
            this.tmrTimeUpdate.Enabled = true;
            this.tmrTimeUpdate.Interval = 200;
            this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 71);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(130, 24);
            this.lblEmployeeName.TabIndex = 39;
            this.lblEmployeeName.Text = "Họ tên nhân viên";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartment.Location = new System.Drawing.Point(10, 95);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(112, 24);
            this.lblDepartment.TabIndex = 41;
            this.lblDepartment.Text = "Phòng ban";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrActiveBarcode
            // 
            this.tmrActiveBarcode.Enabled = true;
            this.tmrActiveBarcode.Interval = 1000;
            this.tmrActiveBarcode.Tick += new System.EventHandler(this.tmrActiveBarcode_Tick);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(6, 171);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(308, 24);
            this.lblError.TabIndex = 39;
            this.lblError.Text = "Nhân viên này không tồn tại trong hệ thống !";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // tmrUpdateMessage
            // 
            this.tmrUpdateMessage.Interval = 600;
            this.tmrUpdateMessage.Tick += new System.EventHandler(this.tmrUpdateMessage_Tick);
            // 
            // frmBarCodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 230);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.picEmployee);
            this.Controls.Add(this.lblEmployeeInfo);
            this.Controls.Add(this.txtBarCodeID);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBarCodeReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình đọc mã vạch @EVSoft";
            this.Load += new System.EventHandler(this.frmBarCodeReader_Load);
            this.Resize += new System.EventHandler(this.frmBarCodeReader_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.MenuItem mnuHide;
        private System.Windows.Forms.MenuItem mnuShow;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuStart;
        private System.Windows.Forms.MenuItem mnuStop;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.TextBox txtBarCodeID;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Timer tmrTimeUpdate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Timer tmrActiveBarcode;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrUpdateMessage;
    }
}