using System;
using System.Threading;


namespace ExpendedoraG2_2024_1
{
    internal class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantproductos;
        private float precio;
        #endregion

        #region Métodos
        private void Saludar()
        {
            Console.WriteLine("Bienvendo, elige un producto");
        }
        private void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        //Regresa el código
        public string MostrarProducto()
        {
            string codigo = "";
            Console.WriteLine("3A: Doritos \n 3B: Churrumais");
            Console.WriteLine("Ingresa el código del producto");
            codigo = Console.ReadLine();
            return codigo;
            //string codigo = Console.ReadLine();
            //return codigo;

        }

        public void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("Precio:{0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio:{0}", precio-6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto válido");
                    break;


            }
        }
        #endregion

        #region Constructor
        public Expendedora()
        {
            marca = "AMS";
            precio = 18;
            Saludar();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}",marca);
            LimpiarDisplay();
            string codigo= MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);


        }

        public Expendedora(bool Mantenimiento)

        {
            if (Mantenimiento== true )

            Console.WriteLine("ENTRANDO EN MODO MANTENIMIENTO");
       
        }
        #endregion
    }
}
