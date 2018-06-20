using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;

namespace 书店销售管理系统.DBConnector
{
    class ADOConnector
    {
        private static string DBname = "BookShop";
        private static string _SqlUserName = "sa";
        private static string _SqlPwd = "Jpch980814";
        public static string ConStr = "Data Source=localhost,1433;database=" + DBName + ";User id=" + SqlUserName + "; PWD=" + SqlPwd;
        private static SqlConnection adoCon = new SqlConnection(ConStr);

        public static string DBName
        {
            get { return DBname; }
            set { DBname = value; }
        }
        public static string SqlUserName
        {
            get { return _SqlUserName; }
            set { _SqlUserName = value; }
        }

        public static string SqlPwd
        {
            get { return _SqlPwd; }
            set { _SqlPwd = value; }
        }


        public static void SetArgs(string name, string user, string pwd)
        {
            DBName = name;
            SqlUserName = user;
            SqlPwd = pwd;
            ConStr = "Data Source=localhost,1433;database=" + DBName + ";User id=" + SqlUserName + "; PWD=" + SqlPwd;
        }

        public static void AddNewSysUser(string name, string pwd, string power)
        {
            try
            {
                String SqlStem = "INSERT INTO AdminList VALUES(\'" + name + "\',\'" + pwd + "\',\'" + power + "\',NULL)";
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("INSERT, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static DataSet GetAllEmails()
        {
            try
            {
                string SqlStr = "SELECT 邮箱 FROM VipList WHERE 邮箱 IS NOT NULL ";
                adoCon.Open();
                SqlDataAdapter odbcAdapter = new SqlDataAdapter(SqlStr, adoCon);
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
                adoCon.Close();
            }
            return null;
        }

        public static bool TestConn(string name, string user, string pwd)
        {
            try
            {
                ConStr = "Data Source=localhost,1433;database=" + name + ";User id=" + user + "; PWD=" + pwd;
                SqlConnection TestADOConn = new SqlConnection(ConStr);
                TestADOConn.Open();
                TestADOConn.Close();
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
                adoCon.Open();
                string SqlStr = "SELECT 密码 FROM AdminList WHERE 用户名='" + str + "'";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();
                adoAdapter.Fill(ds);
                pwd_sha1 = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return pwd_sha1;
        }

        public static int InquireBookNumbers(string iSBN)
        {
            int num = 0;
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT 存货 FROM Book WHERE 图书号='" + iSBN + "'";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();
                adoAdapter.Fill(ds);
                num = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return num;
        }

        public static void AddToSellList(long vipNum, string iSBN, string time, int num, double money, string tranMode, string tranNum, string remarks)
        {
            try
            {
                String SqlStem = "INSERT INTO SellList VALUES(\'" + vipNum + "\',\'" + iSBN + "\',\'" + time + "\',\'" + num + "\',\'" + money + "\',\'" + tranMode + "\',\'" + tranNum + "\',\'" + remarks + "\')";
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("INSERT, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static void AddNewBooks(string iSBN, string bookname, string authorname, string publishname, string classificationname, double money, string remarks)
        {
            int i = 0;
            try
            {
                String SqlStem = "INSERT INTO BookInfo VALUES(\'" + iSBN + "\',\'" + bookname + "\',\'" + authorname + "\',\'" + publishname + "\',\'" + classificationname + "\',\'" + money + "\',\'" + remarks + "\')";
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                i += MyCommand.ExecuteNonQuery();

                SqlStem = "INSERT INTO Book VALUES(\'" + iSBN + "\',\'" + "0" + "\',\'" + money + "\',\'" + remarks + "\')";
                MyCommand = new SqlCommand(SqlStem, adoCon);
                i += MyCommand.ExecuteNonQuery();
                MessageBox.Show("INSERT, Total rows affected:" + i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static DataSet SelectBookTable()
        {
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT Book.图书号,书名,存货,标价 FROM Book JOIN BookInfo ON Book.图书号=BookInfo.图书号";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
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
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static DataSet SelectBookInfoTable(int mode, string str)
        {
            try
            {
                adoCon.Open();
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
                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }

        public static DataSet SelectSellListTable(string starttime, string endtime)
        {
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT * FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\' AND \'" + endtime + "\'";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }

        public static string GetPower(string name)
        {
            String power = "";
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT 权限 FROM AdminList WHERE 用户名='" + name + "'";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();
                adoAdapter.Fill(ds);
                power = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return power;
        }

        public static void ChangeAdminPwd(string oldpwd_sha1, string newpwd_sha1)
        {
            String SqlStem = "UPDATE AdminList SET 密码 = \'" + newpwd_sha1 + "\'WHERE 用户名 = \'" + LoginInfo.LoginName + "\'" + " AND 密码 = \'" + oldpwd_sha1 + "\'";

            try
            {
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
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
                adoCon.Close();
            }
        }

        public static DataSet SelectVipTTable()
        {
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT 编号,用户名,密码 AS '密码(已加密)',手机号,邮箱,会员等级 FROM VipList";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }

        public static String GetNewVipNum()
        {
            String newVipNum = "";
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT MAX(编号)+1 FROM VipList";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();
                adoAdapter.Fill(ds);
                newVipNum = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
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
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("INSERT, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static void UpgradeVipLevel(string num)
        {
            String SqlStem = "UPDATE VipList SET 会员等级=1+(SELECT 会员等级 FROM VipList WHERE 编号=\'" + num + "\') WHERE 编号=\'" + num + "\'";

            try
            {
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static void ChangeVipInfo(string num, string name, string pwd_sha1, string phone, string mail)
        {
            String SqlStem = "UPDATE VipList SET 用户名=\'" + name + "\',密码=\'" + pwd_sha1 + "\',邮箱=  NULL  ,手机号=\'" + phone + "\' WHERE 编号=\'" + num + "\'";
            if (mail.Equals(""))
                SqlStem = "UPDATE VipList SET 用户名=\'" + name + "\',密码=\'" + pwd_sha1 + "\',邮箱=\'" + mail + "\',手机号=\'" + phone + "\' WHERE 编号=\'" + num + "\'";
            try
            {
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static String FindBestSellingBook(string starttime, string endtime)
        {
            String str = "";
            try
            {
                adoCon.Open();

                string SqlStr = "SELECT * FROM (SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名) AS R1 WHERE 销量=( SELECT MAX(R.销量) FROM (SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名) AS R )";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();
                adoAdapter.Fill(ds);
                str += (ds.Tables[0].Rows[0].ItemArray[0].ToString() + "  " + ds.Tables[0].Rows[0].ItemArray[1].ToString() + "  " + ds.Tables[0].Rows[0].ItemArray[2].ToString());
                return str;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }

        public static DataSet ShowSalesReport(string starttime, string endtime)
        {
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
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
                adoCon.Open();
                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }

        public static DataSet ShowAllDiscounts()
        {
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT * FROM VipType";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }

        public static void ChangeDiscount(int mode, string text)
        {
            String SqlStem = "UPDATE VipType SET 优惠折扣=\'" + text + "\' WHERE 等级=\'" + mode + "\'";
            try
            {
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static void ChangePrice(string isbn, string price)
        {
            String SqlStem = "UPDATE Book SET 标价=\'" + price + "\' WHERE 图书号=\'" + isbn + "\'";
            try
            {
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
                MessageBox.Show("Update, Total rows affected:" + MyCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
        }

        public static string GetPrice(string isbn)
        {
            String price = "";
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT 标价 FROM Book WHERE 图书号='" + isbn + "'";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();
                adoAdapter.Fill(ds);
                price = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return price;
        }

        public static DataSet ShowAllSysUsers()
        {
            try
            {
                adoCon.Open();
                string SqlStr = "SELECT 用户名,权限,备注 FROM AdminList";

                SqlDataAdapter adoAdapter = new SqlDataAdapter(SqlStr, adoCon);
                DataSet ds = new DataSet();

                adoAdapter.Fill(ds);
                return ds;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoCon.Close();
            }
            return null;
        }




        public static void ExecuteStem(String SqlStem)
        {
            try
            {
                adoCon.Open();
                SqlCommand MyCommand = new SqlCommand(SqlStem, adoCon);
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
                adoCon.Close();
            }
        }
    }
}
