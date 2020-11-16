using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPessentials_2
{
    public class Manager : Worker
    {
        public Manager(string name, string surname, sbyte age, decimal salary, string assistant):base(salary, name, surname, age )
        {
            Assistant = assistant;
        }

        public string Assistant { get; set; }
        public List<Worker> Members { get; set; }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine($"\nAssistant:{Assistant}");
            foreach (Worker item in Members)
            {
                Console.WriteLine(item.ToString());
            }
        }
   
    }
}
