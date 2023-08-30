using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraG2_2024_1
{
    internal class Cafe : Expendedora
    {
        #region Propiedades 
        public override byte Temperatura 
        { 
            get => base.Temperatura; 
            set 
            {
                if (50 < value && value < 70)
                {
                    temperatura = value;
                }
                else
                {

                    temperatura = 60;
                }
            }
        }
        #endregion

        public Cafe()
        {
            Saludar();
            Temperatura = 60;
            Console.WriteLine("Temperatura: {0}",Temperatura);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            Precio = 10;
            MostrarPrecio(codigo);
        }
        public Cafe(bool Mantenimiento)
        {
            if (Mantenimiento)
                Console.WriteLine("Entrando en modo mantenimiento");
            else
                Saludar();
        }
        public Cafe(int cantidadProductos)
        {
            Console.WriteLine("La expendedora de cafe contiene {0}", cantidadProductos);

        }
        #region Metodos
        public override string MostrarProducto()
        {
            Console.WriteLine("4C: Americano \n 4D: Expresso");
            string codigo = Console.ReadLine();
            return codigo;
        }
        public override void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "4C":
                    Console.WriteLine("Precio ${0}", Precio+3);
                    break;
                case "4D":
                    Console.WriteLine("Precio ${0}", Precio+6);
                    break;
                    default:
                    Console.WriteLine("Elige un productor válido");
                    break;

            }
        }
        #endregion

    }
}
