using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Module
{
    public class House 
    {

        /* Дом состоит из фундамента(Basement), стен(Wall), окон(Window), дверей(Door), крыши(Part).*/

        //public List<Basement> Basements { get; set; }
        //public List<Window> Windows { get; set; }
        //public List<Door> Doors { get; set; }
        //public List<Roof> Roofs { get; set; }
        //public List<Walls> Wall { get; set; }

        public List<IPart> PartsHouse { get; set; }

        public void CreateHousePlan()
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                IPart w = new Walls();
                PartsHouse.Add(w);
            }

        }

    }
}
