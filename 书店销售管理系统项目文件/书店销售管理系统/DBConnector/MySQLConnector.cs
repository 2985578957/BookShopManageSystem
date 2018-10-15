using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace 书店销售管理系统.DBConnector
{
    /// <summary>
    /// 用单例模式的实现数据库连接类
    /// </summary>
    class MySQLConnector
    {
        // 定义一个静态变量来保存类的实例
        private static MySQLConnector uniqueInstance;

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        // 定义私有构造函数，使外界不能创建该类实例
        private MySQLConnector()
        {
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static MySQLConnector GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new MySQLConnector();
                    }
                }
            }
            return uniqueInstance;
        }


                private static MySqlConnection adoCon = new MySqlConnection(ConStr);

        public bool TestConn(string name, string user, string pwd)
        {
            try
            {
                ConStr = "Data Source=localhost,1433;database=" + name + ";User id=" + user + "; PWD=" + pwd;
                MySqlConnection TestADOConn = new MySqlConnection(ConStr);
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

    }
}