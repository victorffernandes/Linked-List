using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Element<D>
    {
        public D data;
        public Element<D> successor = null;

        public Element(D d)
        {
            data = d;
        }


    }

    class LinkedList <T>
    {
        Element<T> root;
        public void print()
        {
            Element<T> actual = root;
            do{
                Console.WriteLine(actual.data);
                actual = actual.successor;
            }
            while (actual.successor != null);
            Console.WriteLine(actual.data);
        }

        public void Remove(int index) {
            Element<T> a = root;
            Element<T> b = null;
            for (int i = 0;i< index; i++) {
                b = a;
                a = a.successor;
            }
            if (a.successor != null) b.successor = a.successor;
            else b.successor = null;
        }

        public void AddAtBeggining(T value) {
            Element<T> g = new Element<T>(value);
            g.successor = root;
            root = g;
        }

        public void InsertAt(int index,T value) {
            if (index == 0) AddAtBeggining(value);
            else if (getLength() - 1 == index) push(value);
            else
            {
                Element<T> a = root;
                Element<T> b = null;
                Element<T> c = new Element<T>(value);
                for (int i = 0; i < index; i++)
                {
                    b = a;
                    a = a.successor;
                }
                b.successor = c;
                c.successor = a;
            }
        }

        public T getItem(int index) {
            Element<T> a = root;
            for (int i = 0;i< index; i++) {
                a = a.successor;
            }
            return a.data;
        }

        public int getLength() {
            Element<T> actual = root;
            int i = 1;
            while (actual.successor != null)
            {
                i++;
                actual = actual.successor;
            }
            if (root == null) return 0;
            else return i;
        }

        public void push(T i) {
            if (root == null) {
                root = new Element<T>(i);
            }
            else {
                Element<T> actual = root;
                while (actual.successor != null)
                {
                    actual = actual.successor;
                }
                actual.successor = new Element<T>(i);
            }
        }

    }
}
