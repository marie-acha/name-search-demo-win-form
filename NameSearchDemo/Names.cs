using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSearchDemo
{
    internal class Names
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Names (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            string output = string.Format("{0,-15}{1,-15}",LastName,FirstName);
            return output;
        }
    }
}
