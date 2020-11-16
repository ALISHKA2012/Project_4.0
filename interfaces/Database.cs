using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace interfaces
{
    public class Database<T> : IEnumerable
    {
        private List<T> _list;
        

        public Database(List<T>list)
        {
            _list = list;
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
