﻿using System;
using System.Runtime.ExceptionServices;
using System.Threading;


namespace ExpendedoraG2_2024_1
{
    internal abstract class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantproductos;
        private byte temperatura;
        private float precio;


        #endregion

        #region Propiedades
        public byte Temperatura { 
            get => temperatura; 
            set 
                {
                if (0< value && value < 25)
                    temperatura = value;
                else 
                    temperatura = 20;
            }
        }

        public string Marca { get => marca; set => marca = value; }
        #endregion

        #region Métodos
        public void Saludar()
        {
            Console.WriteLine("Bienvendo, elige un producto");
        }
        public void LimpiarDisplay()
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
            Marca = "AMS";
            precio = 18;
            Saludar();
            LimpiarDisplay();
            


        }

        public Expendedora(bool Mantenimiento)

        {
            Temperatura = 20;
            if (Mantenimiento == true )

            Console.WriteLine("ENTRANDO EN MODO MANTENIMIENTO");
            Console.WriteLine("Cambiando temperatura");
            LimpiarDisplay();
            for(int i = 0; i<20; i++)
            {
                Temperatura++;
               
            }
            Console.WriteLine("Mostrando temperatura {0} [°C]", Temperatura);
        }
        #endregion
    }
}
