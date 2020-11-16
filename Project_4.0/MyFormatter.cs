using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Project_4._0
{
    internal class MyFormatter : IFormatter
    {
        private string userEmail;
        private LogStatus logStatus;

        public MyFormatter(string userEmail, LogStatus logStatus)
        {
            this.userEmail = userEmail;
            this.logStatus = logStatus;
        }

        public string Format()
        {
            return $"{userEmail} {logStatus} {DateTime.Now}";
        }
    }
}