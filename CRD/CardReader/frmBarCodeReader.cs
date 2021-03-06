using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ServiceProcess;
using System.Windows.Forms;
using EVSoft.CardReader;

namespace CardReader
{
    public partial class frmBarCodeReader : Form
    {
        private bool bClose;
        private SwipeDO swipeDO = null;
        private int barCodeType = 8;
        //private bool checkConnection = true;
        //private List<TimeInOutEntity> listTimeInOut =new List<TimeInOutEntity>();

        public frmBarCodeReader()
        {
            InitializeComponent();

            this.Closing +=new CancelEventHandler(frmBarCodeReader_Closing);
            this.Text += " (" + DateTime.Today.ToString("dd/MM/yyyy") + ")";

            //axPortPowerSwipe1.PortOpen = true;
            txtBarCodeID.Text = "";
            bClose = false;
        }

        private void frmBarCodeReader_Load(object sender, EventArgs e)
        {
            Utils util = new Utils();
            util.getSettings();

            if (Utils.settings.BarCodeType.CompareTo("JAN-13")==0)
                barCodeType = 13;

            txtBarCodeID.MaxLength = barCodeType;
            txtBarCodeID.Focus();

            //swipeDO = new SwipeDO();
            //swipeDO.GetAllUser();
            myCompany.MyApp.Config.ModuleConfig.CheckConnection(Utils.settings.Server, Utils.settings.Database,
                                                                Utils.settings.UserName, Utils.settings.Password);
        }

        private void LoadEmployee(string BarCodeID)
        {
            int employeeID = 0;

            txtBarCodeID.Text = BarCodeID;

            swipeDO = new SwipeDO();
            DataSet dataSet = swipeDO.GetEmployeeInfoByBarCode(BarCodeID);
            if (dataSet != null)
            {
                DataTable dbtable = dataSet.Tables[0];

                if (dbtable.Rows.Count == 0)
                {
                    lblError.Text = "Nhân viên này không tồn tại trong hệ thống !";
                    lblError.Visible = true;
                    //btnImport.Visible = false;

                    tmrUpdateMessage.Enabled = true;
                    //txtEmployeeName.Text = "Nhân viên này không tồn tại trong hệ thống !";
                    //txtBarCodeID.Text = string.Empty;
                    txtEmployeeName.Text = "";
                    lblTime.Text = "";
                    txtDepartment.Text = "";
                    picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");

                    Sound.Play(Application.StartupPath + "/IMAGES/wReadError.wav", PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC);
                }
                else
                {
                    lblError.Visible = false;
                    foreach (DataRow dataRow in dbtable.Rows)
                    {
                        employeeID = (int)dataRow["EmployeeID"];
                        txtEmployeeName.Text = dataRow["EmployeeName"].ToString();
                        txtDepartment.Text = dataRow["DepartmentName"].ToString();

                        if (dataRow["Picture"] != DBNull.Value)
                        {
                            string PictureFileName = Utils.settings.PicturePath + '\\' + dataRow["Picture"].ToString();
                            try
                            {
                                picEmployee.Image = Image.FromFile(PictureFileName);
                            }
                            catch
                            {
                                picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");
                            }
                        }
                        else
                        {
                            picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");
                        }
                    }

                    int ret = ProcessCardData(employeeID);

                    if (ret != 0)
                    {
                        //					Sound.Play("IMAGES\\wGoodRead.wav", PlaySounáolags.SND_FILENAME | PlaySoundFlags.SND_ASYNC);
                        Sound.Play(Application.StartupPath + "/IMAGES/wGoodRead.wav", PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC);
                        txtBarCodeID.Text = string.Empty;
                        txtBarCodeID.Focus();
                    }
                    else
                    {
                        //if (checkConnection)
                        //{
                        MessageBox.Show("Không thể lưu thông tin vào ra của nhân viên này!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                        //}
                    }
                }
            }
            else 
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu, hãy xem lại cấu hình hệ thống ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtEmployeeName.Text = "";
                lblTime.Text = "";
                txtDepartment.Text = "";
                picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");

                Sound.Play(Application.StartupPath + "/IMAGES/wReadError.wav", PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC);
            }
        }

        private int ProcessCardData(int employeeID)
        {
            // Insert Time in, time out
            DateTime timenow = DateTime.Now;

            //			String WorkingDay = timenow.ToShortDateString();

            String TimeInOut = timenow.ToShortTimeString();

            string TimeIn = swipeDO.GetTimeIn(employeeID, timenow.Date);

            lblTime.Text = TimeIn.Equals("") ? "Giờ vào: " : "Giờ ra: ";
            lblTime.Text += TimeInOut;

            int intValue = swipeDO.SaveCardData(timenow.Date, employeeID, TimeInOut, TimeIn);

            ////Loi them du lieu
            //if (intValue==0)
            //{
            //    //Ko ket noi duoc co so du lieu
            //    if (!myCompany.MyApp.Config.ModuleConfig.CheckConnection(Utils.settings.Server, Utils.settings.Database, Utils.settings.UserName, Utils.settings.Password))
            //    {
            //        checkConnection = false;

            //        TimeInOutEntity entityTimeInOut = new TimeInOutEntity();
            //        entityTimeInOut.WorkingDay = timenow.Date;
            //        entityTimeInOut.EmployeeID = employeeID;
            //        entityTimeInOut.TimeOut = TimeInOut;
            //        entityTimeInOut.TimeIn = TimeIn;

            //        listTimeInOut.Add(entityTimeInOut);

            //        lblError.Text = "Số nhân viên chưa đồng bộ: " + listTimeInOut.Count;
            //        lblError.Visible = true;
            //        btnImport.Visible = true;
            //    }
            //    else
            //    {
            //        checkConnection = true;
            //        lblError.Visible = false;
            //        btnImport.Visible = false;
            //    }
            //}

            return intValue;
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtCardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lấy về đối tượng TextBox
            TextBox textBox = (TextBox)sender;
            textBox.ImeMode = ImeMode.Disable;

            // Lấy về mã ASCII của ký tự vừa được gõ vào TextBox
            char keycode = e.KeyChar;
            int c = (int)keycode;

            // Kiểm tra ký tự vừa nhập vào có phải là các số nằm trong khoảng
            // 0..9
            if (Char.IsNumber(keycode) || c == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void tmrTimeUpdate_Tick(object sender, EventArgs e)
        {
            ShowCurrentTime();
        }
        private void ShowCurrentTime()
        {
            DateTime now = DateTime.Now;
            lblClock.Text = now.ToLongTimeString();
        }

        private void btnConfig_Click(object sender, System.EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }

        private void contextMenu1_Popup(object sender, System.EventArgs e)
        {
            mnuShow.Enabled = !(this.Visible);
            mnuHide.Enabled = this.Visible;
            Load_Service();


        }
        private void Load_Service()
        {
            ServiceController sc = new ServiceController("CardReaderService");
            try
            {
                if (sc.Status.ToString() == "Stopped")
                {
                    mnuStart.Enabled = true;
                    mnuStop.Enabled = false;
                }
                else
                {
                    mnuStart.Enabled = false;
                    mnuStop.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void frmBarCodeReader_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (!bClose)
                e.Cancel = true;
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            bClose = true;
            this.Close();
        }

        private void frmBarCodeReader_Resize(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            txtBarCodeID.Focus();
            this.Activate();
        }

        private void mnuStart_Click(object sender, System.EventArgs e)
        {
            ServiceController sc = new ServiceController("CardReaderService");
            try
            {
                if (sc.Status.ToString() == "Stopped")
                {
                    sc.Start();
                    sc.Refresh();
                    mnuStart.Enabled = false;
                    mnuStop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại","Thông báo");
            }
        }

        private void mnuStop_Click(object sender, System.EventArgs e)
        {
            ServiceController sc = new ServiceController("CardReaderService");
            try
            {
                if (sc.CanStop)
                {
                    if (sc.Status.ToString() != "Stopped")
                    {
                        sc.Stop();
                        sc.Refresh();
                        mnuStart.Enabled = true;
                        mnuStop.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
        }

        private void mnuShow_Click(object sender, System.EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            txtBarCodeID.Focus();
            this.Activate();
        }

        private void mnuHide_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBarCodeID_TextChanged(object sender, EventArgs e)
        {
            string strBarCode = txtBarCodeID.Text.Trim();
            if (strBarCode.Length == barCodeType -1)
            {
                if (BarCodeHelper.IsBarCodeValid("0" + strBarCode))
                {
                    strBarCode = "0" + strBarCode;
                    txtBarCodeID.Text = strBarCode;
                    return;
                }
            }

            //Neu ma lay ve la 8 hoac 13 so thi thuc hien 
            if (strBarCode.Length == barCodeType)
            {
                txtBarCodeID.Focus();

                if (barCodeType == 8)
                    strBarCode = "00000" + strBarCode;
                LoadEmployee(strBarCode);
            }
        }

        private void txtBarCodeID_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtBarCodeID.Text.Trim() !=string.Empty && e.KeyCode ==Keys.Enter)
            {
                int lenBarCode = txtBarCodeID.Text.Trim().Length;
                //Chen cac so 0 dang truong cho du 8 hoac 13 so
                if (lenBarCode < barCodeType)
                {
                    string strBarCode = txtBarCodeID.Text.Trim();
                    for (int i = 0; i < (barCodeType - lenBarCode); i++)
                        strBarCode = "0" + strBarCode;

                    txtBarCodeID.Text = strBarCode;
                }
            }
        }

        private void tmrActiveBarcode_Tick(object sender, EventArgs e)
        {
            if (ActiveControl != txtBarCodeID)
                txtBarCodeID.Focus();
        }

        private void tmrUpdateMessage_Tick(object sender, EventArgs e)
        {
            txtBarCodeID.Text = string.Empty;
            lblError.Visible = false;

            tmrUpdateMessage.Enabled = false;
        }

        #region offline function

        //private void tmrCheckConnection_Tick(object sender, EventArgs e)
        //{
        //    if (myCompany.MyApp.Config.ModuleConfig.CheckConnection(Utils.settings.Server, Utils.settings.Database, Utils.settings.UserName, Utils.settings.Password))
        //    {
        //        checkConnection = true;
        //    }
        //    else
        //    {
        //        checkConnection = false;
        //    }

        //    if(listTimeInOut.Count > 0)
        //    {
        //        lblError.Text = "Số nhân viên chưa đồng bộ: " + listTimeInOut.Count;
        //        lblError.Visible = true;
        //        btnImport.Visible = true;
        //    }
        //    else
        //    {
        //        lblError.Visible = false;
        //        btnImport.Visible = false;
        //    }
        //}

        //private void btnImport_Click(object sender, EventArgs e)
        //{
        //    if(listTimeInOut.Count > 0)
        //    {
        //        checkConnection = true;

        //        if (myCompany.MyApp.Config.ModuleConfig.CheckConnection(Utils.settings.Server, Utils.settings.Database, Utils.settings.UserName, Utils.settings.Password))
        //        {
        //            int returnValue = 0;
        //            foreach (TimeInOutEntity entity in listTimeInOut)
        //            {
        //                returnValue = swipeDO.SaveCardData(entity.WorkingDay, entity.EmployeeID, entity.TimeOut, entity.TimeIn);

        //                if (returnValue == 0)
        //                    listTimeInOut.Remove(entity);
        //            }
        //        }

        //        if(listTimeInOut.Count == 0)
        //        {
        //            lblError.Visible = false;
        //            btnImport.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        checkConnection = false;
        //        if (listTimeInOut.Count > 0)
        //        {
        //            lblError.Text = "Số nhân viên chưa đồng bộ: " + listTimeInOut.Count;
        //            lblError.Visible = true;
        //            btnImport.Visible = true;
        //        }
        //    }
        //}

        #endregion
    }
}