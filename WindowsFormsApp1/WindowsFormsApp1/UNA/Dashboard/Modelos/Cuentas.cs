using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Cuentas
    {
        public Cuentas(int cedula, string nombre, double monto, int telefono, string direcion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Monto = monto;
            Telefono = telefono;
            Direcion = direcion;
        }

        public Cuentas()
        {
            
        }

        public int Cedula
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public double Monto
        {
            get;
            set;
        }

        public int Telefono
        {
            get;
            set;
        }

        public string Direcion
        {
            get;
            set;
        }
    }
}