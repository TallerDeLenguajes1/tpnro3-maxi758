using System;
using System.Collections.Generic;
using System.Text;

namespace tpnro3_maxi758
{
    class Cadeteria
    {
        String nombre;
        List<Cadete> ListadoDeCadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Cadete> ListadoDeCadetes1 { get => ListadoDeCadetes; set => ListadoDeCadetes = value; }
    }
}
