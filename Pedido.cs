using System;
using System.Collections.Generic;
using System.Text;

namespace tpnro3_maxi758
{
    public enum Estado { Recibido = 0, Realizandose, Entregado, Desconocido};
    class Pedido
    {
        static int identificador = 0;
        int id;
        Cliente cliente;
        String Observaciones;
        Estado estadoActual;
        static String[] nombre = new String[5] {"maxi","tero","cachito","yisus","quinteroooo" };
        static String[] direccion = new string[5] {"pje chubut 2023", "colon 2356", "bernabe araoz 1234", "jujuy 4000", "fake street 123" };
        static String[] telefono = new string[5] { "34543533", "345435545", "34534354", "354556767", "34446678" };
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
        public Estado EstadoActual { get => estadoActual; set => estadoActual = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public void setEstado(int number)
        {
            if (number >= 0 && number < 3)
                estadoActual = (Estado)number;
            else
                estadoActual = Estado.Desconocido;
        }
        public Pedido()
        {
            Random r = new Random();
            id = identificador++;
            Observaciones = "nada";
            estadoActual = (Estado)r.Next(0, 3);
            cliente = new Cliente(nombre[r.Next(0, 5)], direccion[r.Next(0, 5)], telefono[r.Next(0, 5)]);
        }
        public void Mostrar()
        {
            Console.WriteLine(this.EstadoActual);
            Console.WriteLine(this.cliente.Direccion+" "+this.cliente.Nombre+" "+this.cliente.Telefono);
            Console.WriteLine(this.Observaciones1);
            Console.WriteLine(this.id);
        }
    }
}
