using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Module
{
    public class Door : IPart
    {
        public DateTime EndtWork
        {
            get;

            set;
        }

        public string Name
        {
            get;
            set;
        }

        public DateTime StartWork
        {
            get;
            set;
        }
    }
}
