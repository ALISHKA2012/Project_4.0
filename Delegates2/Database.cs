using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates2.Program;

namespace Delegates2
{
    public class Database<T>
    {
        private IEnumerable<T> _collection;
        public Database(IEnumerable<T> collection)
        {
            _collection = collection;
        }
        public IEnumerable<T> Find(Func<T, bool > func)
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
