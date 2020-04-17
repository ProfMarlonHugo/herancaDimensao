using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_02
{
    class Unidimensional
    {
        private double coordenada_x;

        /*construtor*/
        public Unidimensional(double x)
        {
            setCoordenadaX(x);
        }

        /*get set*/
        protected double getCoordenadaX()
        {
            return this.coordenada_x;
        }

        protected void setCoordenadaX(double x)
        {
            this.coordenada_x = x;
        }

        public virtual string imprimir()
        {
            return "Estou na classe unidimensional. Minha coordenada é x:" + getCoordenadaX();
        }
    }
}
