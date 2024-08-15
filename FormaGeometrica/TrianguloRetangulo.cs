
namespace FormaGeometrica
{
    internal class TrianguloRetangulo : FormaGeometrica
    {

        public float Base;
        public float Altura;
        public float Hipotenusa { get { return MathF.Sqrt(Base * Base + Altura * Altura); } }

        public override float Area()
        {
            return (Base * Altura) / 2;
        }

        public override float Perimetro()
        {
            return (Base + Altura + Hipotenusa);
        }
    }
}
