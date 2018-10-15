using System;
using System.Data;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;

namespace 书店销售管理系统.DBConnector
{
    class Connector
    {
        public static DataSet SelectVipSumBuy(string vipnum)
        {
            return MySQLConnector.GetInstance().Select(
                "SELECT 交易人编号,SUM(收款金额) AS 总消费金额 FROM SellList WHERE 交易人编号<>0 AND 交易人编号 LIKE '" + vipnum + "'  GROUP BY 交易人编号"
            );
        }

        public static void AddNewSysUser(string name, string pwd, string power)
        {
            int affected_row = MySQLConnector.GetInstance().Insert(
                "INSERT INTO AdminList VALUES(\'" + name + "\',\'" + pwd + "\',\'" + power + "\',NULL)"
                );
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static DataSet GetAllEmails()
        {
            return MySQLConnector.GetInstance().Select(
                "SELECT 邮箱 FROM VipList WHERE 邮箱 IS NOT NULL "
            );
        }

        public static String Get_Pwd(String str)
        {
            return MySQLConnector.GetInstance().Select(
                "SELECT 密码 FROM AdminList WHERE 用户名='" + str + "'"
            ).Tables[0].Rows[0].ItemArray[0].ToString();
        }

        public static int InquireBookNumbers(string iSBN)
        {
            int num = 0;
            DataSet ds = MySQLConnector.GetInstance().Select(
                "SELECT 存货 FROM Book WHERE 图书号='" + iSBN + "'"
            );
            num = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            return num;
        }

        public static void AddToSellList(long vipNum, string iSBN, string time, int num, double money, string tranMode, string tranNum, string remarks)
        {
            int affected_row = MySQLConnector.GetInstance().Insert(
                "INSERT INTO SellList VALUES(\'" + vipNum + "\',\'" + iSBN + "\',\'" + time + "\',\'" + num + "\',\'" + money + "\',\'" + tranMode + "\',\'" + tranNum + "\',\'" + remarks + "\')"
                );
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static void AddNewBooks(string iSBN, string bookname, string authorname, string publishname, string classificationname, double money, string remarks)
        {
            int affected_row = 0;
            affected_row += MySQLConnector.GetInstance().Insert(
                "INSERT INTO BookInfo VALUES(\'" + iSBN + "\',\'" + bookname + "\',\'" + authorname + "\',\'" + publishname + "\',\'" + classificationname + "\',\'" + money + "\',\'" + remarks + "\')"
                );
            affected_row += MySQLConnector.GetInstance().Insert(
               "INSERT INTO Book VALUES(\'" + iSBN + "\',\'" + "0" + "\',\'" + money + "\',\'" + remarks + "\')"
               );

            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static DataSet SelectBookTable()
        {
            return MySQLConnector.GetInstance().Select(
                   "SELECT Book.图书号,书名,存货,标价 FROM Book JOIN BookInfo ON Book.图书号=BookInfo.图书号"
               );
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
            int affected_row = MySQLConnector.GetInstance().Update(SqlStem);
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static DataSet SelectBookInfoTable(int mode, string str)
        {
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
            return MySQLConnector.GetInstance().Select(SqlStr);
        }

        public static DataSet SelectSellListTable(string starttime, string endtime)
        {
            return MySQLConnector.GetInstance().Select(
                "SELECT * FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\' AND \'" + endtime + "\'"
            );
            
        }

        public static string GetPower(string name)
        {
            return MySQLConnector.GetInstance().Select(
                      "SELECT 权限 FROM AdminList WHERE 用户名='" + name + "'"
                  ).Tables[0].Rows[0].ItemArray[0].ToString();
        }

        public static void ChangeAdminPwd(string oldpwd_sha1, string newpwd_sha1)
        {
            String SqlStem = "UPDATE AdminList SET 密码 = \'" + newpwd_sha1 + "\'WHERE 用户名 = \'" + LoginInfo.LoginName + "\'" + " AND 密码 = \'" + oldpwd_sha1 + "\'";
            int affected_row = MySQLConnector.GetInstance().Update(SqlStem);
            if (affected_row == 1)
                MessageBox.Show("修改成功，Update, Total rows affected:1");
            else
                MessageBox.Show("修改失败，Update, Total rows affected:0");
        }

        public static DataSet SelectVipTTable()
        {
            return MySQLConnector.GetInstance().Select(
                "SELECT 编号,用户名,密码 AS '密码(已加密)',手机号,邮箱,会员等级 FROM VipList"
            );
        }

        public static String GetNewVipNum()
        {
            return MySQLConnector.GetInstance().Select(
                "SELECT MAX(编号)+1 FROM VipList"
            ).Tables[0].Rows[0].ItemArray[0].ToString();
        }

        public static void AddNewVip(string num, string name, string pwd_sha1, string phone, string mail)
        {
            String SqlStem = "INSERT INTO VipList VALUES(\'" + num + "\',\'" + name + "\',\'" + pwd_sha1 + "\',\'" + phone + "\',NULL,\'1\',NULL)";
            if (mail.Equals(""))
                SqlStem = "INSERT INTO VipList VALUES(\'" + num + "\',\'" + name + "\',\'" + pwd_sha1 + "\',\'" + phone + "\',\'" + mail + "\',\'1\',NULL)";
            int affected_row = MySQLConnector.GetInstance().Insert(SqlStem);
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static void UpgradeVipLevel(string num)
        {
            int affected_row = MySQLConnector.GetInstance().Update(
   "UPDATE VipList SET 会员等级=1+(SELECT 会员等级 FROM VipList WHERE 编号=\'" + num + "\') WHERE 编号=\'" + num + "\'"
   );
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static void ChangeVipInfo(string num, string name, string pwd_sha1, string phone, string mail)
        {
            String SqlStem = "UPDATE VipList SET 用户名=\'" + name + "\',密码=\'" + pwd_sha1 + "\',邮箱=  NULL  ,手机号=\'" + phone + "\' WHERE 编号=\'" + num + "\'";
            if (mail.Equals(""))
                SqlStem = "UPDATE VipList SET 用户名=\'" + name + "\',密码=\'" + pwd_sha1 + "\',邮箱=\'" + mail + "\',手机号=\'" + phone + "\' WHERE 编号=\'" + num + "\'";

            int affected_row = MySQLConnector.GetInstance().Update(SqlStem);
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static String FindBestSellingBook(string starttime, string endtime)
        {
            DataSet ds = MySQLConnector.GetInstance().Select(
       "SELECT * FROM (SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名) AS R1 WHERE 销量=( SELECT MAX(R.销量) FROM (SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名) AS R )"
   );
            String str = (ds.Tables[0].Rows[0].ItemArray[0].ToString() + "  " + ds.Tables[0].Rows[0].ItemArray[1].ToString() + "  " + ds.Tables[0].Rows[0].ItemArray[2].ToString());
            return str;
        }

        public static DataSet ShowSalesReport(string starttime, string endtime)
        {
            return MySQLConnector.GetInstance().Select(
       "SELECT R.图书号,书名,MAX(销量) AS 销量 FROM BookInfo AS B JOIN (SELECT 图书号,SUM(数量) AS 销量 FROM SellList WHERE 交易时间 BETWEEN \'" + starttime + "\'AND \'" + endtime + "\' GROUP BY 图书号) AS R ON R.图书号=B.图书号 GROUP BY R.图书号,书名"
   );
        }

        public static DataSet ShowIncomeStat(int mode)
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
            return MySQLConnector.GetInstance().Select(SqlStr);
        }

        public static DataSet ShowAllDiscounts()
        {
            return MySQLConnector.GetInstance().Select(
    "SELECT * FROM VipType"
);
        }

        public static void ChangeDiscount(int mode, string text)
        {
            int affected_row = MySQLConnector.GetInstance().Update(
"UPDATE VipType SET 优惠折扣=\'" + text + "\' WHERE 等级=\'" + mode + "\'"
);
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static void ChangePrice(string isbn, string price)
        {
            int affected_row = MySQLConnector.GetInstance().Update(
                "UPDATE Book SET 标价=\'" + price + "\' WHERE 图书号=\'" + isbn + "\'"
                );
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
        }

        public static string GetPrice(string isbn)
        {
            return MySQLConnector.GetInstance().Select(
    "SELECT 标价 FROM Book WHERE 图书号='" + isbn + "'"
).Tables[0].Rows[0].ItemArray[0].ToString();
        }

        public static DataSet ShowAllSysUsers()
        {
            return MySQLConnector.GetInstance().Select(
       "SELECT 用户名,权限,备注 FROM AdminList"
   );
        }




        public static void ExecuteStem(String SqlStem)
        {
            int affected_row = MySQLConnector.GetInstance().Insert(SqlStem);
            MessageBox.Show("INSERT, Total rows affected:" + affected_row);
            ;
                if (affected_row == 1)
                    MessageBox.Show("执行成功");
                else
                    MessageBox.Show("执行失败");
        }
    }
}
