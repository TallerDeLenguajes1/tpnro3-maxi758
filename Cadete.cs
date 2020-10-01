using System;
using System.Collections.Generic;
using System.Text;

namespace tpnro3_maxi758
{
    class Cadete
    {
        static int identificador = 0;
        int id;
        String nombre;
        String direccion;
        String telefono;
        List<Pedido> ListadoDePedidos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        internal List<Pedido> ListadoPedidos { get => ListadoPedidos; set => ListadoPedidos = value; }
    }
}
