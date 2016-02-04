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

        public Element(D d) {
            data = d;
        }


    }
}
