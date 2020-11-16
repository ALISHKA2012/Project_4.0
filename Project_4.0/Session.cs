using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4._0
{
    public static class Session
    {
        public static User User { get; set; }

        public static Form1 Form1 { get; set; }

        public static DashBoard DashBoard { get; set; }

    public static AdminPanel AdminPanel { get; set; }
        public static  User_List_Form User_List_Form { get; set; }
        public static Log_List_Form Log_List_Form { get; set; }
        public static string Code { get; set; }
    }
}
