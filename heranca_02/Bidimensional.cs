using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_02
{
    class Bidimensional : Unidimensional
    {
        private double coordenada_y;

        /*construtor*/
        public Bidimensional (double x, double y) : base(x)
        {
            this.setCoordenadaY(y);
        }

        /*get set*/
        protected double getCoordenadaY()
        {
            return this.coordenada_y;
        }

        protected void setCoordenadaY(double y)
        {
            this.coordenada_y = y;
        }

        public override string imprimir()
        {
            return "Estou na classe bidimensional. Minha coordenada é x:" + this.getCoordenadaX() +
                " y:" + this.getCoordenadaY(); ;
        }
    }
}
