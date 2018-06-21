using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;

namespace 书店销售管理系统.DBConnector
{
    class ODBCConnector
    {
        private static string _ODBCSource = "BookShop2";
        private static string _SqlUserName = "sa";
        private static string _SqlPwd = "Jpch980814";
        public static string ConStr = "DSN=" + ODBCSource + ";UID=" + SqlUserName + ";PWD=" + SqlPwd;
        private static OdbcConnection odbcCon = new OdbcConnection(ConStr);

        public static string ODBCSource
        {
            get { return _ODBCSource; }
            set { _ODBCSource = value; }
        }
        public static string SqlUserName
        {
            get { return _SqlUserName; }
            set { _SqlUserName = value; }
        }

        public static DataSet SelectVipSumBuy(string vipnum)
        {
            try
            {
                string SqlStr = "SELECT 交易人编号,SUM(收款金额) AS 总消费金额 FROM SellList WHERE 交易人编号<>0 AND 交易人编号 LIKE '" + vipnum+"'  GROUP BY 交易人编号";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static string SqlPwd
        {
            get { return _SqlPwd; }
            set { _SqlPwd = value; }
        }


        public static void SetArgs(string name, string user, string pwd)
        {
            ODBCSource = name;
            SqlUserName = user;
            SqlPwd = pwd;
            ConStr = "DSN=" + ODBCSource + ";UID=" + SqlUserName + ";PWD=" + SqlPwd;
            odbcCon = new OdbcConnection(ConStr);
        }

        public static void AddNewSysUser(string name, string pwd, string power)
        {
            try
            {
                String SqlStem = "INSERT INTO AdminList VALUES(\'" + name + "\',\'" + pwd + "\',\'" + power + "\',NULL)";
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("INSERT, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static DataSet GetAllEmails()
        {
            try
            {
                string SqlStr = "SELECT 邮箱 FROM VipList WHERE 邮箱 IS NOT NULL ";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static bool TestConn(string name, string user, string pwd)
        {
            try
            {
                ConStr = "DSN=" + name + ";UID=" + user + ";PWD=" + pwd;
                OdbcConnection TestOdbcConn = new OdbcConnection(ConStr);
                TestOdbcConn.Open();
                TestOdbcConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static String Get_Pwd(String str)
        {
            String pwd_sha1 = "";
            try
            {
                string SqlStr = "SELECT 密码 FROM AdminList WHERE 用户名='" + str + "'";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();
                odbcAdapter.Fill(ds);
                pwd_sha1 = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return pwd_sha1;
        }

        public static int InquireBookNumbers(string iSBN)
        {
            int num = 0;
            try
            {
                string SqlStr = "SELECT 存货 FROM Book WHERE 图书号='" + iSBN + "'";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();
                odbcAdapter.Fill(ds);
                num = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return num;
        }

        public static void AddToSellList(long vipNum, string iSBN, string time, int num, double money, string tranMode, string tranNum, string remarks)
        {
            try
            {
                String SqlStem = "INSERT INTO SellList VALUES(\'" + vipNum + "\',\'" + iSBN + "\',\'" + time + "\',\'" + num + "\',\'" + money + "\',\'" + tranMode + "\',\'" + tranNum + "\',\'" + remarks + "\')";
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("INSERT, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static void AddNewBooks(string iSBN, string bookname, string authorname, string publishname, string classificationname, double money, string remarks)
        {
            int i = 0;
            try
            {
                String SqlStem = "INSERT INTO BookInfo VALUES(\'" + iSBN + "\',\'" + bookname + "\',\'" + authorname + "\',\'" + publishname + "\',\'" + classificationname + "\',\'" + money + "\',\'" + remarks + "\')";
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                i += MyCommand.ExecuteNonQuery();

                SqlStem = "INSERT INTO Book VALUES(\'" + iSBN + "\',\'" + "0" + "\',\'" + money + "\',\'" + remarks + "\')";
                MyCommand = new OdbcCommand(SqlStem, odbcCon);
                i += MyCommand.ExecuteNonQuery();
                MessageBox.Show("INSERT, Total rows affected:" + i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static DataSet SelectBookTable()
        {
            try
            {
                string SqlStr = "SELECT Book.图书号,书名,存货,标价 FROM Book JOIN BookInfo ON Book.图书号=BookInfo.图书号";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static void Replenishment(int mode, string isbn, int num)
        {
            String SqlStem = "";
            if (mode == 1)//修改
            {
                SqlStem = "UPDATE Book SET 存货 = \'" + num + "\'WHERE 图书号 = \'" + isbn + "\'";
            }
            else if (mode == 2)
            {//增加
                SqlStem = "UPDATE Book SET 存货 = \'" + num + "\'+ (SELECT 存货 FROM Book WHERE 图书号 = \'" + isbn + "\') WHERE 图书号 = \'" + isbn + "\'";
            }
            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static DataSet SelectBookInfoTable(int mode, string str)
        {
            try
            {
                odbcCon.Open();
                string SqlStr = "SELECT Book.图书号,书名,作者,出版社,图书分类,存货,价格 AS 原价,标价 FROM BookInfo JOIN Book ON BookInfo.图书号=Book.图书号";
                if (mode == 0)
                {
                    SqlStr = "SELECT Book.图书号,书名,作者,出版社,图书分类,存货,价格 AS 原价,标价 FROM BookInfo JOIN Book ON BookInfo.图书号=Book.图书号";
                }
                else if (mode == 1)
                {
                    SqlStr = "SELECT Book.图书号,书名,作者,出版社,图书分类,存货,价格 AS 原价,标价 FROM BookInfo JOIN Book ON BookInfo.图书号=Book.图书号 WHERE 图书分类 LIKE \'" + str + "\'";
                }
                else if (mode == 2)
                {
                    SqlStr = "SELECT Book.图书号,书名,作者,出版社,图书分类,存货,价格 AS 原价,标价 FROM BookInfo JOIN Book ON BookInfo.图书号=Book.图书号 WHERE 书名 LIKE \'" + str + "\'";
                }
                else if (mode == 3)
                {
                    SqlStr = "SELECT Book.图书号,书名,作者,出版社,图书分类,存货,价格 AS 原价,标价 FROM BookInfo JOIN Book ON BookInfo.图书号=Book.图书号 WHERE 出版社 LIKE \'" + str + "\'";
                }
                else if (mode == 4)
                {
                    SqlStr = "SELECT Book.图书号,书名,作者,出版社,图书分类,存货,价格 AS 原价,标价 FROM BookInfo JOIN Book ON BookInfo.图书号=Book.图书号 WHERE 作者 LIKE \'" + str + "\'";
                }
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static DataSet SelectSellListTable(string starttime, string endtime)
        {
            try
            {
                odbcCon.Open();  
                string SqlStr = "SELECT * FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\' AND \'" + endtime + "\'";

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static string GetPower(string name)
        {
            String power = "";
            try
            {
                string ConStr = "DSN=" + ODBCSource + ";UID=" + SqlUserName + ";PWD=" + SqlPwd;
                string SqlStr = "SELECT 权限 FROM AdminList WHERE 用户名='" + name + "'";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();
                odbcAdapter.Fill(ds);
                power = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return power;
        }

        public static void ChangeAdminPwd(string oldpwd_sha1, string newpwd_sha1)
        {
            String SqlStem = "UPDATE AdminList SET 密码 = \'" + newpwd_sha1 + "\'WHERE 用户名 = \'" + LoginInfo.LoginName + "\'" + " AND 密码 = \'" + oldpwd_sha1 + "\'";
            //UPDATE Book SET 存货 = 10 + (SELECT 存货 FROM Book WHERE 图书号 = '978-7-121-23856-7') WHERE 图书号 = '978-7-121-23856-7'

            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                if (MyCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("修改成功，Update, Total rows affected:1");
                else
                    MessageBox.Show("修改失败，Update, Total rows affected:0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static DataSet SelectVipTTable()
        {
            try
            {
                string SqlStr = "SELECT 编号,用户名,密码 AS '密码(已加密)',手机号,邮箱,会员等级 FROM VipList";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static String GetNewVipNum()
        {
            String newVipNum = "";
            try
            {
                odbcCon.Open();
                string SqlStr = "SELECT MAX(编号)+1 FROM VipList";

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();
                odbcAdapter.Fill(ds);
                newVipNum = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return newVipNum;
        }

        public static void AddNewVip(string num, string name, string pwd_sha1, string phone, string mail)
        {
            try
            {
                String SqlStem = "INSERT INTO VipList VALUES(\'" + num + "\',\'" + name + "\',\'" + pwd_sha1 + "\',\'" + phone + "\',NULL,\'1\',NULL)";
                if (mail.Equals(""))
                    SqlStem = "INSERT INTO VipList VALUES(\'" + num + "\',\'" + name + "\',\'" + pwd_sha1 + "\',\'" + phone + "\',\'" + mail + "\',\'1\',NULL)";
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("INSERT, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static void UpgradeVipLevel(string num)
        {
            String SqlStem = "UPDATE VipList SET 会员等级=1+(SELECT 会员等级 FROM VipList WHERE 编号=\'" + num + "\') WHERE 编号=\'" + num + "\'";

            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static void ChangeVipInfo(string num, string name, string pwd_sha1, string phone, string mail)
        {
            String SqlStem= "UPDATE VipList SET 用户名=\'" + name + "\',密码=\'" + pwd_sha1 + "\',邮箱=  NULL  ,手机号=\'" + phone + "\' WHERE 编号=\'" + num + "\'";
            if (mail.Equals(""))
               SqlStem = "UPDATE VipList SET 用户名=\'" + name + "\',密码=\'" + pwd_sha1 + "\',邮箱=\'" + mail + "\',手机号=\'" + phone + "\' WHERE 编号=\'" + num + "\'";
            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static String FindBestSellingBook(string starttime, string endtime)
        {
            String str = "";
            try
            {
                odbcCon.Open();
                string SqlStr = "SELECT * FROM (SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名) AS R1 WHERE 销量=( SELECT MAX(R.销量) FROM (SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名) AS R )";

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();
                odbcAdapter.Fill(ds);
                str += (ds.Tables[0].Rows[0].ItemArray[0].ToString() + "  " + ds.Tables[0].Rows[0].ItemArray[1].ToString() + "  " + ds.Tables[0].Rows[0].ItemArray[2].ToString());
                return str;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static DataSet ShowSalesReport(string starttime, string endtime)
        {
            try
            {
                odbcCon.Open();
                string SqlStr = "SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名";

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static DataSet ShowIncomeStat(int mode)
        {
            try
            {
                string SqlStr = "";
                if (mode == 0)
                {
                    SqlStr = "SELECT year(交易时间) 年,sum(收款金额) AS 销售合计 FROM SellList GROUP BY year(交易时间)";
                }
                else if (mode == 1)
                {
                    SqlStr = "SELECT year(交易时间) 年,month(交易时间) 月,day(交易时间) 日,sum(收款金额) AS 销售合计 FROM SellList GROUP BY year(交易时间),month(交易时间),day(交易时间)";
                }
                else if (mode == 2)
                {
                    SqlStr = "SELECT year(交易时间) 年,month(交易时间) 月,sum(收款金额) AS 销售合计 FROM SellList GROUP BY year(交易时间),month(交易时间)";
                }
                else if (mode == 3)
                {
                    SqlStr = "select year(交易时间) 年份, " +
                            "case when month(交易时间) between 1 and 3 then '一季度' " +
                            "when month(交易时间) between 4 and 6 then '二季度' " +
                            "when month(交易时间) between 7 and 9 then '三季度' " +
                            "when month(交易时间) between 10 and 12 then '四季度' end 季度, " +
                            "sum(收款金额) 金额 " +
                            "from SellList " +
                            "where year(交易时间) between 1970 and 2030 " +
                            "group by year(交易时间), " +
                            "case when month(交易时间) between 1 and 3 then '一季度' " +
                            "when month(交易时间) between 4 and 6 then '二季度' " +
                            "when month(交易时间) between 7 and 9 then '三季度' " +
                            "when month(交易时间) between 10 and 12 then '四季度' end ";
                }
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static DataSet ShowAllDiscounts()
        {
            try
            {
                string SqlStr = "SELECT * FROM VipType";
                odbcCon.Open();
                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }

        public static void ChangeDiscount(int mode, string text)
        {
            String SqlStem = "UPDATE VipType SET 优惠折扣=\'" + text + "\' WHERE 等级=\'" + mode + "\'";
            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static void ChangePrice(string isbn, string price)
        {
            String SqlStem = "UPDATE Book SET 标价=\'" + price + "\' WHERE 图书号=\'" + isbn + "\'";
            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }

        public static string GetPrice(string isbn)
        {
            String price = "";
            try
            {
                odbcCon.Open();
                string SqlStr = "SELECT 标价 FROM Book WHERE 图书号='" + isbn + "'";

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();
                odbcAdapter.Fill(ds);
                price = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return price;
        }

        public static DataSet ShowAllSysUsers()
        {
            try
            {
                odbcCon.Open();
                string SqlStr = "SELECT 用户名,权限,备注 FROM AdminList";

                OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
                DataSet ds = new DataSet();

                odbcAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
            return null;
        }




        public static void ExecuteStem(String SqlStem)
        {
            try
            {
                odbcCon.Open();
                OdbcCommand MyCommand = new OdbcCommand(SqlStem, odbcCon);
                if (MyCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("执行成功");
                else
                    MessageBox.Show("执行失败");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odbcCon.Close();
            }
        }
    }
}
