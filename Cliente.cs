using System;
using System.Collections.Generic;
using System.Text;

namespace tpnro3_maxi758
{
    
    class Cliente
    {
        static int identificador = 0;
        int id;
        String nombre;
        String direccion;
        String telefono;
    
        public Cliente(String _nombre, String _direccion, String _telefono)
        {
      
            identificador++;
            id = identificador;
            nombre = _nombre;
            direccion = _direccion;
            telefono = _telefono;
        
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
