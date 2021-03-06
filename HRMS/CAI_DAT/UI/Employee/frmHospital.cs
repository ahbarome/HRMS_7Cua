using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.UI.Employee
{
    public partial class frmHospital : Form
    {
        private DepartmentDO departmentDO = null;
        private DataSet dsPosition = null;
        private DataTable dtPosition = null;
        private int selectedPosition = -1;

        public DataSet PositionDataSet
        {
            set { dsPosition = value; }
        }

        public int SelectedPosition
        {
            set { selectedPosition = value; }
        }
        
        public frmHospital()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            ChangeToCurrentLang();

            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }

            base.Refresh();
        }

        private void ChangeToCurrentLang()
        {
            //this.groupBox1.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1");
            //this.lblPositionName.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1_lblPositionName");
            //this.lblPositionShortName.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1_lblPositionSortName");
            //this.lblDescription.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1_lblDecription");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmPosition_bntClose");
            this.btnOK.Text = WorkingContext.LangManager.GetString("frmPosition_bntOK");
        }

        /// <summary>
        /// Nạp lại dữ liệu trong hàng được chọn hiện tại lên các textbox
        /// </summary>
        private void LoadCurrentPosition()
        {
            DataRow dr = dtPosition.Rows[selectedPosition];
            if (dr != null)
            {
                txtPositionName.Text = dr["HospitalName"].ToString();
                txtPositionShortName.Text = dr["HospitalID"].ToString();
                txtDescription.Text = dr["HospitalAddress"].ToString();
            }
        }

        private void frmHospital_Load(object sender, EventArgs e)
        {
            Refresh();
            departmentDO = new DepartmentDO();
            dtPosition = dsPosition.Tables[0];
            if (selectedPosition >= 0)
            {
                //string str = WorkingContext.LangManager.GetString("frmPosition_Text3");
                this.Text = "Sửa thông tin bệnh viện";
                //this.Text = str;
                LoadCurrentPosition();
            }
            else
            {
                //string str = WorkingContext.LangManager.GetString("frmPosition_Text2");
                this.Text = "Thêm một bệnh viện mới";
                //this.Text = str;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
             if (txtPositionName.Text.Trim() == "")
			{
                //string str = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Messa1");
                //string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Title1");
				MessageBox.Show("Bạn chưa nhập tên bệnh viện!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtPositionShortName.Text.Trim() == "")
			{
                //string str = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Messa2");
                //string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Title1");
                MessageBox.Show("Bạn chưa nhập mã bệnh viện!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
            if (txtPositionShortName.Text.Trim().Length >10)
            {
                //string str = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Messa2");
                //string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Title1");
                MessageBox.Show("Mã bệnh viện ko được quá 10 kí tự!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			if (selectedPosition < 0)
			{
				DataRow dr = dtPosition.NewRow();
				
				dr.BeginEdit();
                dr["HospitalName"] = txtPositionName.Text.Trim();
                dr["HospitalID"] = txtPositionShortName.Text.Trim();
                dr["HospitalAddress"] = txtDescription.Text;
				dr.EndEdit();
				dsPosition.Tables[0].Rows.Add(dr);

				int result = departmentDO.AddNewHospital(txtPositionName.Text,txtDescription.Text,txtPositionShortName.Text);
				if (result == 2) 
				{
                    //string str = WorkingContext.LangManager.GetString("frmPosition_Add_ThongBao_Messa");
                    //string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_ThongBao_Title");
                    MessageBox.Show("Thêm bệnh viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.AcceptChanges();
					this.Close();
				}
				if(result == 1)
				{
                    //string str = WorkingContext.LangManager.GetString("frmPosition_Add_CanhBao_Messa");
                    //string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_ThongBao_Title");
                    MessageBox.Show("Bệnh viện hoặc tên viết tắt đã tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.RejectChanges();
				}
			}
			else
			{
				DataRow dr = dsPosition.Tables[0].Rows[selectedPosition];
				dr.BeginEdit();
				dr["HospitalName"] = txtPositionName.Text.Trim();
				dr["HospitalID"] = txtPositionShortName.Text.Trim();
				dr["HospitalAddress"] = txtDescription.Text;
				dr.EndEdit();

                int result = departmentDO.UpdateHospital(txtPositionShortName.Text, txtPositionName.Text, txtDescription.Text, Convert.ToInt32(dr["HospitalCode"]));
				dsPosition.AcceptChanges();
				if (result ==2 ) 
				{
                    //string str = WorkingContext.LangManager.GetString("frmPosition_UpDate_ThongBao_Messa");
                    //string str1 = WorkingContext.LangManager.GetString("frmPosition_UpDate_ThongBao_Title");
					MessageBox.Show("Cập nhật bệnh viện thành công!", "Cập nhật",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.AcceptChanges();
					this.Close();
				}
				if(result == 1)
				{
                    //string str = WorkingContext.LangManager.GetString("frmPosition_Add_CanhBao_Messa");
                    //string str1 = WorkingContext.LangManager.GetString("frmPosition_UpDate_ThongBao_Title");
                    MessageBox.Show("Mã bệnh viện đã tồn tại trong hệ thống !", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.RejectChanges();
				}
			}
            
        }
    }
}