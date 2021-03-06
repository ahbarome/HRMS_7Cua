using System;
using System.Collections.Generic;
using System.Text;
using EVSoft.HRMSLicense;
using Microsoft.Win32;

namespace EVSoft.HRMSLisence
{
    public class TrialVersion
    {
        public const int TRIAL_PERIOD_DAYS = 7;//Số ngày được phép sử dụng
        public const int LOGIN_COUNT = 20; //Số lần login vào hệ thống
        private const string Path1 = "Software\\HRMS";
        private const string Path2 = "Software\\Classes\\CLSID\\" + "{79A0C36D-C80C-4739-82A2-691987B517A1}";
        private static Encryption enc = new Encryption("EVSOFT", "EVSOFT"); 

        public static void RegisterRegistry()
        {
            string date = DateTime.Now.Date.ToString("d");

            RegistryKey regKey = Registry.CurrentUser;
            Registration.CreaterKey(regKey, Path1, "Company", "Evsoft");
            Registration.CreaterKey(regKey, Path1, "Version", "Trial");
            Registration.CreaterKey(regKey, Path1, "DateUsed", enc.Encrypt(date));//Ngày ngần nhất sử dụng
            Registration.CreaterKey(regKey, Path1, "TimeLeft", enc.Encrypt(TRIAL_PERIOD_DAYS.ToString()));//Ngày sử dụng còn lại
            Registration.CreaterKey(regKey, Path1, "LoginCount", enc.Encrypt(LOGIN_COUNT.ToString()));//Số lần login còn lại 

            regKey = Registry.LocalMachine;
            string value = TRIAL_PERIOD_DAYS.ToString() + ":" + LOGIN_COUNT.ToString();
            Registration.CreaterKey(regKey, Path2, "reg", enc.Encrypt(value));
            regKey.Close();
        }

        public static bool IsRegister()
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.CreateSubKey(Path1);
            if (regKey.ValueCount > 0)
                return true;
            regKey = Registry.LocalMachine;
            regKey = regKey.CreateSubKey(Path2);
            if (regKey.ValueCount > 0)
                return true;
            
            return false;
        }

        public static bool PeriodOfValidity()
        {
            int timeLeft, loginCount;
            GetValueRegistry(out timeLeft, out loginCount);
            if (timeLeft <= 0 || loginCount <= 0)
                return false;
            return true;
        }

        private static void GetValueRegistry(out int timeLeft, out int loginCount)
        {
            try
            {
                string date = DateTime.Now.Date.ToString("d");

                RegistryKey regKey = Registry.CurrentUser;
                //Đọc registry
                string m_DateUsed = enc.Decrypt(Registration.GetKeyValue(regKey, Path1, "DateUsed"));
                timeLeft = int.Parse(enc.Decrypt(Registration.GetKeyValue(regKey, Path1, "TimeLeft")));
                loginCount = int.Parse(enc.Decrypt(Registration.GetKeyValue(regKey, Path1, "LoginCount")));

                regKey = Registry.LocalMachine;
                string[] value = enc.Decrypt(Registration.GetKeyValue(regKey, Path2, "reg")).Split(':');
                if(timeLeft !=int.Parse(value[0]) || loginCount !=int.Parse(value[1]))
                {
                    timeLeft = 0;
                    loginCount = 0;
                    return;
                }

                //Update lại registry
                regKey = Registry.CurrentUser;
                int count = timeLeft;
                if (m_DateUsed !=date)
                {
                    Registration.UpdateKey(regKey, Path1, "DateUsed", enc.Encrypt(date));
                    Registration.UpdateKey(regKey, Path1, "TimeLeft", enc.Encrypt((timeLeft - 1).ToString()));//Ngày sử dụng còn lại
                    count--;
                }
                Registration.UpdateKey(regKey, Path1, "LoginCount", enc.Encrypt((loginCount-1).ToString()));//Số lần login còn lại 

                regKey = Registry.LocalMachine;
                Registration.UpdateKey(regKey, Path2, "reg", enc.Encrypt(count.ToString() + ":" + (loginCount - 1).ToString()));
                regKey.Close();
            }
            catch(Exception)
            {
                timeLeft = 0;
                loginCount = 0;
            }
        }

        public static void DeleteRegistry()
        {
            RegistryKey regKey = Registry.CurrentUser;
            Registration.DeleteKey(regKey, "Software", "HRMS");

            regKey = Registry.LocalMachine;
            Registration.DeleteKey(regKey, "Software\\Classes\\CLSID", "{79A0C36D-C80C-4739-82A2-691987B517A1}");

            regKey.Close();
        }

    }
}
