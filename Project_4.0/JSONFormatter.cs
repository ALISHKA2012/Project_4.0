using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4._0
{
    class JSONFormatter : IFormatter
    {
        private readonly string _userEmail;
        private readonly LogStatus _status;

        public JSONFormatter(string userEmail, LogStatus status)
        {
            _userEmail = userEmail;
            _status = status;
        }
        public string Format()
        {
            return string.Format("\n[\n\t[user]:[{0}],\n[status]:[{1}],\n\t[time]:[{2}]\n]\n", _userEmail, _status, DateTime.Now);
        }
    }
}
