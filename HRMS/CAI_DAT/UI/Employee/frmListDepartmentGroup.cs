using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Models;

namespace EVSoft.HRMS.UI.Employee
{
    public partial class frmListDepartmentGroup : Form
    {

        #region Variables
        /// <summary>
        /// 
        /// </summary>
        private int selectedRowIndex = -1;
        /// <summary>
        /// 
        /// </summary>
        private DepartmentDO departmentDO = null;
        /// <summary>
        /// 
        /// </summary>
        private DataSet dsPosition = null;
        /// <summary>
        /// 
        /// </summary>
        private DataTable dtPosition = null;

        #endregion
        
        public frmListDepartmentGroup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                //string str = WorkingContext.LangManager.GetString("frmListPosition_Delete_Error_Messa");
                //string str1 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title1");
                MessageBox.Show("Chưa chọn nhóm phòng ban cần xóa", "Xóa nhóm phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DeleteDepartmentGroup();
            }
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        /// <summary>
        /// Xóa chức vụ
        /// </summary>
        private void DeleteDepartmentGroup()
        {
            string PositionName = dtPosition.Rows[selectedRowIndex]["GroupName"].ToString();
            //string str = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Messa1");
            //string str2 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title2");
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm phòng ban '" + PositionName + "' ?", "Xóa nhóm phòng ban", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                int result = 0;
                try
                {
                    result = departmentDO.DeleteDepartmentGroup(Convert.ToInt32(dtPosition.Rows[selectedRowIndex]["GroupID"].ToString()));
                }
                catch
                {

                }
                if (result == 2)
                {
                    //string str1 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Messa2");
                    //string str3 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title2");
                    MessageBox.Show("Xóa nhóm phòng ban thành công!", "Xóa nhóm phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(str1, str3, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtPosition.Rows[selectedRowIndex].Delete();
                    dsPosition.AcceptChanges();
                }
                else if (result == 1)
                {
                    //string str1 = WorkingContext.LangManager.GetString("frmListPosition_Del_ThongBao_Messa3");
                    //string str3 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title2");
                    MessageBox.Show("Xóa nhóm phòng ban thất bại! Đã có phòng ban được gán nhóm phòng ban này!", "Xóa nhóm phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(str1, str3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsPosition.RejectChanges();
                }
                else
                    MessageBox.Show("Lỗi hệ thống !", "Thông báo");
                
                PopulatePositionListView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                //string str = WorkingContext.LangManager.GetString("frmPosition_UpDate_Error_Messa");
                //string str1 = WorkingContext.LangManager.GetString("frmPosition_UpDate_Error_Title");
                MessageBox.Show("Bạn chưa chọn nhóm phòng ban nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmDepartmentGroup frm = new frmDepartmentGroup();
                frm.PositionDataSet = dsPosition;
                frm.SelectedPosition = selectedRowIndex;
                frm.ShowDialog(this);
                PopulatePositionListView();
            }
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmDepartmentGroup frm = new frmDepartmentGroup();
            frm.PositionDataSet = dsPosition;
            frm.ShowDialog(this);
            PopulatePositionListView();
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        private void frmListDepartmentGroup_Load(object sender, EventArgs e)
        {
            Refresh();
            departmentDO = new DepartmentDO();
            PopulatePositionListView();
        }

        private void PopulatePositionListView()
        {
            dsPosition = departmentDO.GetAllGroupDepartments();

            lvwPosition.BeginUpdate();
            lvwPosition.TableModel.Rows.Clear();
            dtPosition = dsPosition.Tables[0];
            if (dtPosition.Rows.Count > 0)
            {
                //				selectedRowIndex = 0;
                int STT = 0;
                foreach (DataRow dr in dtPosition.Rows)
                {
                    STT++;
                    string PositionName = dr["GroupName"].ToString();
                    string PositionShortName = dr["GroupID"].ToString();
                    string Description = dr["GroupDescription"].ToString();

                    Row row = new Row(new string[] { STT.ToString(), PositionName, PositionShortName, Description });
                    row.Tag = STT - 1;
                    lvwPosition.TableModel.Rows.Add(row);
                }
            }
            lvwPosition.EndUpdate();
        }

        private void lvwPosition_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                selectedRowIndex = (int)lvwPosition.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void lvwPosition_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (lvwPosition.SelectedItems.Length > 0)
                {
                    frmDepartmentGroup frm = new frmDepartmentGroup();
                    frm.PositionDataSet = dsPosition;
                    frm.SelectedPosition = selectedRowIndex;
                    frm.ShowDialog(this);
                    PopulatePositionListView();
                }
                selectedRowIndex = -1;
                tableModel1.Selections.Clear();
            }
        }
    }
}