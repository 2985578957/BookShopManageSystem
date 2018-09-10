using System;
using System.Text.RegularExpressions;

namespace 书店销售管理系统.Assembly
{
    class CheckString
    {
        static public bool CheckUInt(string str)
        {
            Regex reg1 = new Regex(@"^+?[1-9]\d*$|^+?0$");
            return reg1.IsMatch(str);
        }

        static public bool CheckUDouble(string str)
        {
            Regex x = new Regex(@"^+?[1-9]\d*(\.\d+)?$|^+?0(\.\d+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            return x.Match(str).Success;
        }

        static public bool CheckISBN(string str)
        {
            Regex reg1 = new Regex(@"^\d+-\d+-\d+-\d+-\d+$");
            return reg1.IsMatch(str);
        }

        static public bool CheckDate(string strDate)
        {
            try
            {
                DateTime.Parse(strDate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool ChechPower(string str)
        {
            Regex reg1 = new Regex(@"^管理员$|^进货员$|^销售员$");
            return reg1.IsMatch(str);
        }

        static public bool ChechEmail(string str)
        {
            Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
            return r.IsMatch(str);
        }
    }
}
