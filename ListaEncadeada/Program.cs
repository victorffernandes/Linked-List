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
            n.InsertAt(3, "Hey I was inserted here");
            n.SwitchPosition(0, 4);
            n.Remove("Sexto");
            n.Remove("Primeiro");
            n.AddAfterValue("Hey I was inserted here", "buu");
            n.print();
            Console.WriteLine("We have "+n.Length+" elements in our Linked List!!");
            Console.ReadKey();
        }
    }
}
