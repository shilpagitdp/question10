using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace eval9
{
    public class flower
    {
        public void decor()
        { Console.WriteLine("Flower decoration completed on stage"); }
    }
    public class chiefguest
    {
        public int chiefg = 1;
        public async Task<chiefguest> arr(chiefguest c1)
        {
            Console.WriteLine("start the event chiefguest arrived");
        }
        public void pick()
        { Console.WriteLine("Chief guest picked from the airport"); }
        public class gifts
        {
            public void stage()
            { Console.WriteLine("Arranged the gifts to be distributed in the stage"); }
        }
        static async Task Main(string[] args)
        {
            chiefguest c1 = new chiefguest();
            await c1.arr(c1);
            c1.pick();
            flower f1 = new flower();
            f1.decor();
            gifts g1 = new gifts();
            g1.stage();
        }
    }
}