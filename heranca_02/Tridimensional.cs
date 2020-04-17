using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_02
{
    class Tridimensional : Bidimensional
    {
        private double coordenada_z;

        /*construtor*/
        public Tridimensional(double x, double y, double z) : base(x, y)
        {
            this.setCoordenadaZ(z);
        }

        /*get set*/
        protected double getCoordenadaZ()
        {
            return this.coordenada_z;
        }

        protected void setCoordenadaZ(double z)
        {
            this.coordenada_z = z;
        }

        public override string imprimir()
        {
            return "Estou na classe tridimensional. Minha coordenada é x:" + this.getCoordenadaX() +
                " y:" + this.getCoordenadaY() +
                " z:" + this.getCoordenadaZ() ;
        }
    }
}
