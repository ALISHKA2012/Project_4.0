using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using static Delegates.Program;

namespace Delegates
{
    public class Database<T>
    {
        private IEnumerable<T> _collection;

        public Database(IEnumerable<T> collection)
        {
            _collection = collection;  
        }

        
        public IEnumerable<T> GoodFilter(Func<T, bool> func)
        {
            foreach (var item in _collection)
            {
                if (func(item))
                {
                    yield return item;
                }
            }

        }
    }
}
