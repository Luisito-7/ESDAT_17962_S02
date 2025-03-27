using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada1
{
    class VAGON
    {
        public int Dato { get; set; }
        public VAGON Sig {  get; set; }

        public VAGON (int dato) 
        {
            Dato = dato;
        }
    }
}
