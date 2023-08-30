using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2
{
    internal abstract class Transporte 
    {
        #region Atributos
        private string marca;
        private int kilometraje;
        public string combustible;
        internal int velocidad;
        


        #endregion

        #region Propiedades
        public string Marca { get => marca; set => marca = value; }
        public virtual int Velocidad 
        { 
            get => velocidad;
            set
            {
                if (20 < value && value < 80)
                    velocidad = value;
                else
                    velocidad = 60;
            }
        }
        #endregion

        #region Metodos

        public void Encender()
        {
            int RMP = 5200;
            Console.WriteLine("Motor encendido");
        }

        public virtual void Acelerar()
        {

        }
        public virtual void Frenar()
        {

        }




        #endregion

    }
}
