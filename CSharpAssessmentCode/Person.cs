using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientation
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public override string ToString()
        {
            return $"Hi, I'm {FullName}";
        }
    }
}