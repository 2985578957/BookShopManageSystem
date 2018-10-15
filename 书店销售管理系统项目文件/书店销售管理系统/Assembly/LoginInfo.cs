using System;

namespace 书店销售管理系统.Assembly
{
    class LoginInfo
    {
        private static String _LoginName;
        private static String _Power;

        public static String LoginName
        {
            get { return _LoginName; }
            set { _LoginName = value; }
        }

        public static String Power
        {
            get { return _Power; }
            set { _Power = value; }
        }
    }
}
