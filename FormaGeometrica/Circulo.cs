using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    internal class Circulo : FormaGeometrica
    {
        public float Raio;

        public override float Area()
        {
            return (MathF.PI * (Raio * Raio));
        }

        public override float Perimetro()
        {
            return (2 * MathF.PI * Raio);
        }
    }
}
