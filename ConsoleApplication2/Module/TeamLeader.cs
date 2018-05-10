using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Module
{
    public class TeamLeader : IWorker
    {
        public string Name  { get; set;}

        public double Salary { get; set;}

        bool IsTeam { get; set; } = true;
    }
}
