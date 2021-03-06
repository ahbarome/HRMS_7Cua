using XPTable.Models;

namespace EVSoft.HRMS.UI.Employee
{
    partial class frmExportExcelBC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwEmployeeBarcode = new XPTable.Models.Table();
            this.columnModel2 = new XPTable.Models.ColumnModel();
            this.clSTT = new XPTable.Models.NumberColumn();
            this.clCompanyName = new XPTable.Models.TextColumn();
            this.clCreditCardName = new XPTable.Models.TextColumn();
            this.clBarcode = new XPTable.Models.TextColumn();
            this.clEmployeeName = new XPTable.Models.TextColumn();
            this.clDepartment = new XPTable.Models.TextColumn();
            this.clStartDate = new XPTable.Models.TextColumn();
            this.clImagePath = new XPTable.Models.TextColumn();
            this.tableModel2 = new XPTable.Models.TableModel();
            this.chkCheckCode = new System.Windows.Forms.CheckBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.cboBarCodeType = new System.Windows.Forms.ComboBox();
            this.rdbTiengVietKD = new System.Windows.Forms.RadioButton();
            this.rdbTCVN3 = new System.Windows.Forms.RadioButton();
            this.rdbUnicode = new System.Windows.Forms.RadioButton();
            this.btnExcelBarCode = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.clCardID = new XPTable.Models.TextColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployeeBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwEmployeeBarcode);
            this.groupBox1.Controls.Add(this.chkCheckCode);
            this.groupBox1.Controls.Add(this.lblCardID);
            this.groupBox1.Controls.Add(this.cboBarCodeType);
            this.groupBox1.Controls.Add(this.rdbTiengVietKD);
            this.groupBox1.Controls.Add(this.rdbTCVN3);
            this.groupBox1.Controls.Add(this.rdbUnicode);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập định dạng trước khi xuất dữ liệu";
            // 
            // lvwEmployeeBarcode
            // 
            this.lvwEmployeeBarcode.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwEmployeeBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwEmployeeBarcode.ColumnModel = this.columnModel2;
            this.lvwEmployeeBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployeeBarcode.Location = new System.Drawing.Point(325, 12);
            this.lvwEmployeeBarcode.Name = "lvwEmployeeBarcode";
            this.lvwEmployeeBarcode.Size = new System.Drawing.Size(142, 150);
            this.lvwEmployeeBarcode.TabIndex = 1;
            this.lvwEmployeeBarcode.TableModel = this.tableModel2;
            this.lvwEmployeeBarcode.Text = "table1";
            this.lvwEmployeeBarcode.Visible = false;
            // 
            // columnModel2
            // 
            this.columnModel2.Columns.AddRange(new XPTable.Models.Column[] {
            this.clSTT,
            this.clCompanyName,
            this.clCreditCardName,
            this.clCardID,
            this.clBarcode,
            this.clEmployeeName,
            this.clDepartment,
            this.clStartDate,
            this.clImagePath});
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.Width = 50;
            // 
            // clCompanyName
            // 
            this.clCompanyName.Text = "Tên công ty";
            // 
            // clCreditCardName
            // 
            this.clCreditCardName.Text = "Tên thẻ";
            // 
            // clBarcode
            // 
            this.clBarcode.Text = "Mã vạch";
            // 
            // clEmployeeName
            // 
            this.clEmployeeName.Text = "Họ tên";
            this.clEmployeeName.Width = 150;
            // 
            // clDepartment
            // 
            this.clDepartment.Text = "Bộ phận";
            // 
            // clStartDate
            // 
            this.clStartDate.Text = "Ngày bắt đầu";
            // 
            // clImagePath
            // 
            this.clImagePath.Text = "Đường dẫn ảnh";
            // 
            // chkCheckCode
            // 
            this.chkCheckCode.AutoSize = true;
            this.chkCheckCode.Location = new System.Drawing.Point(147, 44);
            this.chkCheckCode.Name = "chkCheckCode";
            this.chkCheckCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCheckCode.Size = new System.Drawing.Size(139, 17);
            this.chkCheckCode.TabIndex = 4;
            this.chkCheckCode.Text = "Hiển thị mã check code";
            this.chkCheckCode.UseVisualStyleBackColor = true;
            // 
            // lblCardID
            // 
            this.lblCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCardID.Location = new System.Drawing.Point(149, 16);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(73, 24);
            this.lblCardID.TabIndex = 11;
            this.lblCardID.Text = "Loại mã vạch";
            this.lblCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBarCodeType
            // 
            this.cboBarCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarCodeType.FormattingEnabled = true;
            this.cboBarCodeType.Items.AddRange(new object[] {
            "JAN-8",
            "JAN-13"});
            this.cboBarCodeType.Location = new System.Drawing.Point(223, 19);
            this.cboBarCodeType.Name = "cboBarCodeType";
            this.cboBarCodeType.Size = new System.Drawing.Size(63, 21);
            this.cboBarCodeType.TabIndex = 3;
            // 
            // rdbTiengVietKD
            // 
            this.rdbTiengVietKD.AutoSize = true;
            this.rdbTiengVietKD.Checked = true;
            this.rdbTiengVietKD.Location = new System.Drawing.Point(15, 65);
            this.rdbTiengVietKD.Name = "rdbTiengVietKD";
            this.rdbTiengVietKD.Size = new System.Drawing.Size(126, 17);
            this.rdbTiengVietKD.TabIndex = 2;
            this.rdbTiengVietKD.TabStop = true;
            this.rdbTiengVietKD.Text = "Tiếng việt không dấu";
            this.rdbTiengVietKD.UseVisualStyleBackColor = true;
            // 
            // rdbTCVN3
            // 
            this.rdbTCVN3.AutoSize = true;
            this.rdbTCVN3.Location = new System.Drawing.Point(15, 42);
            this.rdbTCVN3.Name = "rdbTCVN3";
            this.rdbTCVN3.Size = new System.Drawing.Size(90, 17);
            this.rdbTCVN3.TabIndex = 1;
            this.rdbTCVN3.Text = "TCVN3 (ABC)";
            this.rdbTCVN3.UseVisualStyleBackColor = true;
            // 
            // rdbUnicode
            // 
            this.rdbUnicode.AutoSize = true;
            this.rdbUnicode.Location = new System.Drawing.Point(15, 19);
            this.rdbUnicode.Name = "rdbUnicode";
            this.rdbUnicode.Size = new System.Drawing.Size(65, 17);
            this.rdbUnicode.TabIndex = 0;
            this.rdbUnicode.Text = "Unicode";
            this.rdbUnicode.UseVisualStyleBackColor = true;
            // 
            // btnExcelBarCode
            // 
            this.btnExcelBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelBarCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcelBarCode.Location = new System.Drawing.Point(148, 108);
            this.btnExcelBarCode.Name = "btnExcelBarCode";
            this.btnExcelBarCode.Size = new System.Drawing.Size(79, 23);
            this.btnExcelBarCode.TabIndex = 5;
            this.btnExcelBarCode.Text = "&Xuất Excel";
            this.btnExcelBarCode.Click += new System.EventHandler(this.btnExcelBarCode_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(233, 108);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clCardID
            // 
            this.clCardID.Text = "Mã thẻ";
            // 
            // frmExportExcelBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 137);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcelBarCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportExcelBC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xuất excel hỗ trợ mã vạch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployeeBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTiengVietKD;
        private System.Windows.Forms.RadioButton rdbTCVN3;
        private System.Windows.Forms.RadioButton rdbUnicode;
        private System.Windows.Forms.Button btnExcelBarCode;
        private System.Windows.Forms.CheckBox chkCheckCode;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.ComboBox cboBarCodeType;
        private XPTable.Models.Table lvwEmployeeBarcode;
        private XPTable.Models.ColumnModel columnModel2;
        private XPTable.Models.TableModel tableModel2;
        private TextColumn clBarcode;
        private TextColumn clEmployeeName;
        private TextColumn clDepartment;
        private TextColumn clStartDate;
        private TextColumn clImagePath;
        private NumberColumn clSTT;
        private TextColumn clCompanyName;
        private TextColumn clCreditCardName;
        private System.Windows.Forms.Button btnClose;
        private TextColumn clCardID;
    }
}