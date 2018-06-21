using System;
using System.Data;

namespace 书店销售管理系统.DBConnector
{
    class Connector
    {
        private static int mode;

        public static int MODE
        {
            get { return mode; }
            set { mode = value; }
        }
        /*
         * 0 表示ODBC连接
         * 1 表示ADO连接
         */

        public static void SetArgs(string name, string user, string pwd)
        {
            if (mode == 0)
                ODBCConnector.SetArgs(name, user, pwd);
            else//mode==1
                ADOConnector.SetArgs(name, user, pwd);
        }

        public static DataSet SelectVipSumBuy(string vipnum)
        {
            if (mode == 0)
                return ODBCConnector.SelectVipSumBuy(vipnum);
            else//mode==1
                return ADOConnector.SelectVipSumBuy(vipnum);
        }

        public static bool TestConn(string name, string user, string pwd)
        {
            if (mode == 0)
                return ODBCConnector.TestConn(name, user, pwd);
            else//mode==1
                return ADOConnector.TestConn(name, user, pwd);
        }

        public static void AddNewSysUser(string name, string pwd, string power)
        {
            if (mode == 0)
                ODBCConnector.AddNewSysUser(name, pwd, power);
            else//mode==1
                ADOConnector.AddNewSysUser(name, pwd, power);
        }

        public static String Get_Pwd(String str)
        {
            if (mode == 0)
                return ODBCConnector.Get_Pwd(str);
            else//mode==1
                return ADOConnector.Get_Pwd(str);
        }

        public static DataSet GetAllEmails()
        {
            if (mode == 0)
                return ODBCConnector.GetAllEmails();
            else//mode==1
                return ADOConnector.GetAllEmails();
        }

        public static int InquireBookNumbers(string iSBN)
        {
            if (mode == 0)
                return ODBCConnector.InquireBookNumbers(iSBN);
            else//mode==1
                return ADOConnector.InquireBookNumbers(iSBN);
        }

        public static void AddToSellList(long vipNum, string iSBN, string time, int num, double money, string tranMode, string tranNum, string remarks)
        {
            if (mode == 0)
                ODBCConnector.AddToSellList(vipNum, iSBN, time, num, money, tranMode, tranNum, remarks);
            else//mode==1
                ADOConnector.AddToSellList(vipNum, iSBN, time, num, money, tranMode, tranNum, remarks);
        }

        public static void AddNewBooks(string iSBN, string bookname, string authorname, string publishname, string classificationname, double money, string remarks)
        {
            if (mode == 0)
                ODBCConnector.AddNewBooks(iSBN, bookname, authorname, publishname, classificationname, money, remarks);
            else//mode==1
                ADOConnector.AddNewBooks(iSBN, bookname, authorname, publishname, classificationname, money, remarks);
        }

        public static DataSet SelectBookTable()
        {
            if (mode == 0)
                return ODBCConnector.SelectBookTable();
            else//mode==1
                return ADOConnector.SelectBookTable();
        }

        public static void Replenishment(int mode, string isbn, int num)
        {
            if (mode == 0)
                ODBCConnector.Replenishment(mode, isbn, num);
            else//mode==1
                ADOConnector.Replenishment(mode, isbn, num);
        }

        public static DataSet SelectBookInfoTable(int mode, string str)
        {
            if (mode == 0)
                return ODBCConnector.SelectBookInfoTable(mode, str);
            else//mode==1
                return ADOConnector.SelectBookInfoTable(mode, str);
        }

        public static DataSet SelectSellListTable(string starttime, string endtime)
        {
            if (mode == 0)
                return ODBCConnector.SelectSellListTable(starttime, endtime);
            else//mode==1
                return ADOConnector.SelectSellListTable(starttime, endtime);
        }

        public static string GetPower(string name)
        {
            if (mode == 0)
                return ODBCConnector.GetPower(name);
            else//mode==1
                return ADOConnector.GetPower(name);
        }

        public static void ChangeAdminPwd(string oldpwd_sha1, string newpwd_sha1)
        {
            if (mode == 0)
                ODBCConnector.ChangeAdminPwd(oldpwd_sha1, newpwd_sha1);
            else//mode==1
                ADOConnector.ChangeAdminPwd(oldpwd_sha1, newpwd_sha1);
        }

        public static DataSet SelectVipTTable()
        {
            if (mode == 0)
                return ODBCConnector.SelectVipTTable();
            else//mode==1
                return ADOConnector.SelectVipTTable();
        }

        public static String GetNewVipNum()
        {
            if (mode == 0)
                return ODBCConnector.GetNewVipNum();
            else//mode==1
                return ADOConnector.GetNewVipNum();
        }

        public static void AddNewVip(string num, string name, string pwd_sha1, string phone, string mail)
        {
            if (mode == 0)
                ODBCConnector.AddNewVip(num, name, pwd_sha1, phone, mail);
            else//mode==1
                ADOConnector.AddNewVip(num, name, pwd_sha1, phone, mail);
        }

        public static void UpgradeVipLevel(string num)
        {
            if (mode == 0)
                ODBCConnector.UpgradeVipLevel(num);
            else//mode==1
                ADOConnector.UpgradeVipLevel(num);
        }

        public static void ChangeVipInfo(string num, string name, string pwd_sha1, string phone, string mail)
        {
            if (mode == 0)
                ODBCConnector.ChangeVipInfo(num, name, pwd_sha1, phone, mail);
            else//mode==1
                ADOConnector.ChangeVipInfo(num, name, pwd_sha1, phone, mail);
        }

        public static String FindBestSellingBook(string starttime, string endtime)
        {
            if (mode == 0)
                return ODBCConnector.FindBestSellingBook(starttime, endtime);
            else//mode==1
                return ADOConnector.FindBestSellingBook(starttime, endtime);
        }

        public static DataSet ShowSalesReport(string starttime, string endtime)
        {
            if (mode == 0)
                return ODBCConnector.ShowSalesReport(starttime, endtime);
            else//mode==1
                return ADOConnector.ShowSalesReport(starttime, endtime);
        }

        public static DataSet ShowIncomeStat(int mode)
        {
            if (mode == 0)
                return ODBCConnector.ShowIncomeStat(mode);
            else//mode==1
                return ADOConnector.ShowIncomeStat(mode);
        }

        public static DataSet ShowAllDiscounts()
        {
            if (mode == 0)
                return ODBCConnector.ShowAllDiscounts();
            else//mode==1
                return ADOConnector.ShowAllDiscounts();
        }

        public static void ChangeDiscount(int mode, string text)
        {
            if (mode == 0)
                ODBCConnector.ChangeDiscount(mode, text);
            else//mode==1
                ADOConnector.ChangeDiscount(mode, text);
        }

        public static void ChangePrice(string isbn, string price)
        {
            if (mode == 0)
                ODBCConnector.ChangePrice(isbn, price);
            else//mode==1
                ADOConnector.ChangePrice(isbn, price);
        }

        public static string GetPrice(string isbn)
        {
            if (mode == 0)
                return ODBCConnector.GetPrice(isbn);
            else//mode==1
                return ADOConnector.GetPrice(isbn);
        }

        public static DataSet ShowAllSysUsers()
        {
            if (mode == 0)
                return ODBCConnector.ShowAllSysUsers();
            else//mode==1
                return ADOConnector.ShowAllSysUsers();
        }




        public static void ExecuteStem(String SqlStem)
        {
            if (mode == 0)
                ODBCConnector.ExecuteStem(SqlStem);
            else//mode==1
                ADOConnector.ExecuteStem(SqlStem);
        }
    }
}
