using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundTable<Magician> magicians = new RoundTable<Magician>();
            RoundTable<Knight> knights = new RoundTable<Knight>();
            magicians.Add(new Magician("Messing", "Moskow", "future vision"));
            magicians.Add(new Magician("Sadako", "Tokio", "killing gaze"));
            magicians.Add(new Magician("Baba Yaga", "Forest", "dark deeds"));
            knights.Add(new Knight("Terminator", "Los Angeles", "jock"));
            knights.Add(new Knight("Rembo", "?", "don"));
            knights.Add(new Knight("Brus Li", "Hon Kong", "san"));
            magicians.InsertAt(4, new Magician("Bibi", "Jerusalem", "diplomacy"));
            Console.WriteLine(magicians);
            magicians.RemoveAt(5);
            Console.WriteLine(magicians);
            Console.WriteLine("----------");
            Console.WriteLine(magicians[5]);
        }
    }
}
