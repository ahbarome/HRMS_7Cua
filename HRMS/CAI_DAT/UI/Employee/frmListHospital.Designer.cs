namespace EVSoft.HRMS.UI.Employee
{
    partial class frmListHospital
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
            this.cPositionName = new XPTable.Models.TextColumn();
            this.cSTT = new XPTable.Models.TextColumn();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cPositionShortName = new XPTable.Models.TextColumn();
            this.cDescription = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.lvwPosition = new XPTable.Models.Table();
            this.grbPositionList = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvwPosition)).BeginInit();
            this.grbPositionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // cPositionName
            // 
            this.cPositionName.Editable = false;
            this.cPositionName.Text = "Tên bệnh viện";
            this.cPositionName.Width = 200;
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Text = "STT";
            this.cSTT.Width = 50;
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cPositionName,
            this.cPositionShortName,
            this.cDescription});
            // 
            // cPositionShortName
            // 
            this.cPositionShortName.Editable = false;
            this.cPositionShortName.Text = "Mã bệnh viện";
            this.cPositionShortName.Width = 100;
            // 
            // cDescription
            // 
            this.cDescription.Editable = false;
            this.cDescription.Text = "Địa chỉ";
            this.cDescription.Width = 250;
            // 
            // lvwPosition
            // 
            this.lvwPosition.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwPosition.ColumnModel = this.columnModel1;
            this.lvwPosition.EnableToolTips = true;
            this.lvwPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPosition.FullRowSelect = true;
            this.lvwPosition.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwPosition.GridLines = XPTable.Models.GridLines.Both;
            this.lvwPosition.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwPosition.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwPosition.Location = new System.Drawing.Point(8, 16);
            this.lvwPosition.Name = "lvwPosition";
            this.lvwPosition.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwPosition.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPosition.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwPosition.Size = new System.Drawing.Size(610, 354);
            this.lvwPosition.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwPosition.TabIndex = 13;
            this.lvwPosition.TableModel = this.tableModel1;
            this.lvwPosition.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwPosition.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwPosition_MouseDown);
            this.lvwPosition.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwPosition_SelectionChanged);
            this.lvwPosition.DoubleClick += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbPositionList
            // 
            this.grbPositionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPositionList.Controls.Add(this.lvwPosition);
            this.grbPositionList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbPositionList.Location = new System.Drawing.Point(7, 8);
            this.grbPositionList.Name = "grbPositionList";
            this.grbPositionList.Size = new System.Drawing.Size(626, 378);
            this.grbPositionList.TabIndex = 40;
            this.grbPositionList.TabStop = false;
            this.grbPositionList.Text = "Danh sách bệnh viện";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(481, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(401, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 23);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNew.Location = new System.Drawing.Point(321, 392);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(72, 23);
            this.btnAddNew.TabIndex = 36;
            this.btnAddNew.Text = "Thêm &mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(559, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 422);
            this.Controls.Add(this.grbPositionList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClose);
            this.Name = "frmListHospital";
            this.Text = "Danh sách bệnh viện";
            this.Load += new System.EventHandler(this.frmListHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvwPosition)).EndInit();
            this.grbPositionList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XPTable.Models.TextColumn cPositionName;
        private XPTable.Models.TextColumn cSTT;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TextColumn cPositionShortName;
        private XPTable.Models.TextColumn cDescription;
        private XPTable.Models.TableModel tableModel1;
        private XPTable.Models.Table lvwPosition;
        private System.Windows.Forms.GroupBox grbPositionList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
    }
}