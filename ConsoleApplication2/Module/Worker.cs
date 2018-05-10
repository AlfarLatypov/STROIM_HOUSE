using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Module
{
    public class Worker : IWorker
    {
        public string Name
        {
            get;
            set;
        }

        public double Salary


        {
            get;
            set;
        }

        public bool IsTeam { get; set; } = false;


    }
}
