using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace interfaces
{
    public  class CompareBySalary : IComparer
    {
        public int Compare(object x, object y)
        {
            Person person = (Person)x;
            Person person1 = (y as Person);
            if (person.Salary > person1.Salary)

                return -1;
            //------------------------------------------------
            else if (person.Salary < person1.Salary)

                return 1;
            //------------------------------------------------
            else

                return 0;
        }
  
    
     }
}