using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Globals_Class
    {
        public static string ConnectionString = @"Data Source=ARNO\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
        public static int adminNumber;
        public static string UserName;
        public  static int UserID;

        public static int IsAdmin
        {
            get {return adminNumber; }
            set { adminNumber = value; }
        }
        public static string UserInfo
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public static int UserIDs
        {
            get { return UserID; }
            set { UserID = value; }
        }
            
    }
}
