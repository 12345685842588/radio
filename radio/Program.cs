using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio r=new Radio();
            r.Volume=float.Parse(Console.ReadLine());

            Console.WriteLine("aumenta il volume:{0}", r.Aumentavol());
            Console.WriteLine("diminuisci il volume: {0}", r.Diminuiscivol());

            Console.ReadLine();
        }
    }
}
