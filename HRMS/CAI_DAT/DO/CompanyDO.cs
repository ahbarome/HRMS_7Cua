using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
    class CompanyDO
    {
        private SqlConnection conn = null;
        private SqlCommand sqlCommand = null;
        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;

        #region Company management methods

        /// <summary>
        /// Lấy thông tin về công ty
        /// </summary>
        /// <returns></returns>
        public DataSet GetCompanyInfo()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetCompanyInfo", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetCompanyInfo");
                return dataSet;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString());
                return null;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }

        }

        /// <summary>
        /// Cap nhat thong tin cong ty
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="tel"></param>
        /// <param name="fax"></param>
        /// <param name="email"></param>
        /// <param name="website"></param>
        /// <param name="taxcode"></param>
        /// <param name="banhkName"></param>
        /// <param name="bankAccount"></param>
        /// <param name="foundedDay"></param>
        /// <param name="note"></param>
        /// <param name="healthInsuranceID"></param>
        /// <param name="CompanyCode"></param>
        /// <returns></returns>
        public int UpdateDefaultCompanyInfo(string name, string address, string city, string country, string tel, string fax, string email, string district,
                                            string website, string taxcode, string banhkName, string bankAccount, DateTime foundedDay, string note, string healthInsuranceID, string @CompanyCode)
                                            //int companyType, bool inactive, bool defaultCompany, 
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("UpdateDefaultCompanyInfo", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@Name", name);
            sqlCommand.Parameters.Add(param1);

            param1 = new SqlParameter("@Address", address);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@City", city);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@District", district);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@Country", country);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@Tel", tel);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@Fax", fax);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@Email", email);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@Website", website);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@TaxCode", taxcode);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@BankName", banhkName);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@BankAccount", bankAccount);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@FoundedDay", foundedDay);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@Note", note);
            //sqlCommand.Parameters.Add(param1);
            //param1 = new SqlParameter("@CompanyType", companyType);
            //sqlCommand.Parameters.Add(param1);
            //param1 = new SqlParameter("@Inactive", inactive);
            //sqlCommand.Parameters.Add(param1);
            //param1 = new SqlParameter("@DefaultCompany", defaultCompany);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@HealthInsuranceID", healthInsuranceID);
            sqlCommand.Parameters.Add(param1);
            param1 = new SqlParameter("@CompanyCode", CompanyCode);
            sqlCommand.Parameters.Add(param1);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        
#endregion
    }
}
