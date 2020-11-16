using System;

namespace Project_4._0
{
    internal class XMLFormatter : IFormatter
    {
        private string userEmail;
        private LogStatus logStatus;

        public XMLFormatter(string userEmail, LogStatus logStatus)
        {
            this.userEmail = userEmail;
            this.logStatus = logStatus;
        }

        public string Format()
        {
            return string.Format("\n<log>\n\t<user>{0}</user>\n\t<status>{1}</status\n\t<time>{2}</time>\n</log>\n", userEmail, logStatus, DateTime.Now);
        }
    }
}