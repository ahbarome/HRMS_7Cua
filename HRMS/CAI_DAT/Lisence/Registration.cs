using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;


namespace EVSoft.HRMSLisence
{
    public class Registration
    {
        /// <summary>
        /// Tạo key mới trong registry
        /// </summary>
        /// <param name="strPath">Đường dẫn chứa key</param>
        /// <param name="strKeyName">Tên key</param>
        /// <param name="strKeyValue">Giá trị của key</param>
        public static void CreaterKey(RegistryKey regKey,string strPath, string strKeyName, string strKeyValue)
        {
            regKey = regKey.CreateSubKey(strPath);
            regKey.SetValue(strKeyName, strKeyValue);
        }

        /// <summary>
        /// Update key mới trong registry
        /// </summary>
        /// <param name="strPath">Đường dẫn chứa key</param>
        /// <param name="strKeyName">Tên key</param>
        /// <param name="strKeyValue">Giá trị của key</param>
        public static void UpdateKey(RegistryKey regKey,string strPath, string strKeyName, string strKeyValue)
        {
            regKey = regKey.CreateSubKey(strPath);
            regKey.SetValue(strKeyName, strKeyValue);
        }

        /// <summary>
        /// Delete key mới trong registry
        /// </summary>
        /// <param name="strPath">Đường dẫn chứa key</param>
        /// <param name="strKeyName">Tên key</param>
        public static void DeleteKey(RegistryKey regKey, string strPath, string strKeyName)
        {
            regKey = regKey.CreateSubKey(strPath);
            regKey.DeleteSubKey(strKeyName);
        }

        /// <summary>
        /// Get key value mới trong registry
        /// </summary>
        /// <param name="strPath">Đường dẫn chứa key</param>
        /// <param name="strKeyName">Tên key</param>
        public static string GetKeyValue(RegistryKey regKey, string strPath, string strKeyName)
        {
            regKey = regKey.CreateSubKey(strPath);
            return regKey.GetValue(strKeyName).ToString();
        }
    }
}
