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
            ILinkedList<string> n = new ILinkedList<string>();
            n.push("Zero");
            n.push("Primeiro");
            n.push("Segundo");
            n.push("Teceiro");
            n.push("Quarto");
            n.push("Quinto");
            n.push("Sexto");
            n.SwitchPosition(1, 4);
            n.print();
            Console.WriteLine("We have "+n.Length+" elements in our Linked List!!");
            Console.ReadKey();
        }
    }
}
