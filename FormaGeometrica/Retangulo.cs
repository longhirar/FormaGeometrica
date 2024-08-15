using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    internal class Retangulo : FormaGeometrica
    {

        public float Base;
        public float Altura;

        public override float Area()
        {
            return (Base * Altura);
        }

        public override float Perimetro()
        {
            return (Base * 2 + Altura * 2);
        }
    }
}
