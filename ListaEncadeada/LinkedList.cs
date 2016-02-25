using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    #region Element Class
    class Element<D>    {
        public D data;
        public Element<D> successor = null;

        public Element(D d) {
            data = d;
        }
    }
    #endregion


    class ILinkedList <T>
    {
        Element<T> root;

        #region Print All Elements Method
        public void print() {
            Element<T> actual = root;
            do{
                Console.WriteLine(actual.data);
                actual = actual.successor;
            }
            while (actual.successor != null);
            Console.WriteLine(actual.data);
        }
        #endregion

        #region Length Method
        public int getLength()
        {
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

        public int Length
        {
            get {
                return getLength();
            }
        }

        #endregion

        #region Overload Remove Methods
        public void Remove(int index) {
            Element<T> a = root;
            Element<T> b = null;
            if (index != 0)
            {
                for (int i = 0; i < index; i++)
                {
                    b = a;
                    a = a.successor;
                }
                if (a.successor != null) b.successor = a.successor;
                else b.successor = null;
            }
            else {
                root = root.successor;
            }
        }

        public void Remove(T value)
        {
            Element<T> a = root;
            Element<T> b = null;
            if (!root.data.Equals(value))
            {
                while (a.successor != null)
                {
                    if (a.data.Equals(value))
                    {
                        b.successor = a.successor;
                    }
                    b = a;
                    a = a.successor;
                }
                if (a.successor != null) b.successor = a.successor;
                else b.successor = null;
            }
            else {
                root = root.successor;
            }
        }
        #endregion

        public void AddAfterValue(T sort, T value) {
            Element<T> a = root;
            Element<T> New = new Element<T>(value);
            while (a.successor != null)
            {
                if (a.data.Equals(sort))
                {
                    New.successor = a.successor; 
                    a.successor = New;
                }
                a = a.successor;
            }
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

        public void push(T i) {
            if (root == null) {
                root = new Element<T>(i);
            }
            else {
                Element<T> actual = root;
                while (actual.successor != null){
                    actual = actual.successor;
                }
                actual.successor = new Element<T>(i);
            }
        }

        public void SwitchPosition(int i1, int i2){
            int i = 0;
            Element<T> actual = root;
            Element<T> element1 = null;
            Element<T> beforeElement1 = null;
            Element<T> beforeCurrent = null;
            while (actual.successor != null)
            {
                if (i1 == i)
                {
                    beforeElement1 = beforeCurrent;
                    element1 = actual;
                }
                else if (i2 == i)
                {
                    beforeElement1.successor = actual;
                    beforeCurrent.successor = element1;
                    
                    Element<T> h = actual.successor;
                    actual.successor = element1.successor;
                    element1.successor = h;
                }
                beforeCurrent = actual; 
                actual = actual.successor;
                i++;
            }
        }

    }
}
