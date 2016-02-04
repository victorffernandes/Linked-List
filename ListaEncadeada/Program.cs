using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> n = new LinkedList<string>();
            n.push("Primeiro");
            n.push("Segundo");
            n.push("Teceiro");
            n.push("Quarto");
            n.push("Quinto");
            n.push("Sexto");
            n.InsertAt(3, "Hey I was inserted here");
            n.print();
            Console.WriteLine(n.getLength());
            Console.ReadKey();
        }
    }
}
