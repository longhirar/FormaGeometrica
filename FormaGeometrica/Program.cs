using FormaGeometrica;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha a Figura:\n" +
                "1 - Circulo\n" +
                "2 - Triangulo Retangulo\n" +
                "3 - Retangulo\n" +
                "4 - Sair");

            string opcao = Console.ReadLine();

            FormaGeometrica.FormaGeometrica forma = null; // Inicializa a variável `forma` para garantir que ela sempre tenha um valor

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Raio?");
                    float raio = float.Parse(Console.ReadLine());

                    forma = new Circulo { Raio = raio };
                    break;
                case "2":
                    Console.WriteLine("Base?");
                    float _base = float.Parse(Console.ReadLine());
                    Console.WriteLine("Altura?");
                    float altura = float.Parse(Console.ReadLine());

                    forma = new TrianguloRetangulo { Base = _base, Altura = altura };
                    break;
                case "3":
                    Console.WriteLine("Base?");
                    float __base = float.Parse(Console.ReadLine());
                    Console.WriteLine("Altura?");
                    float __altura = float.Parse(Console.ReadLine());

                    forma = new Retangulo { Base = __base, Altura = __altura };
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção não identificada!");
                    break;
            }

            if (forma != null)
            {
                Console.WriteLine("Area: {0}", forma.Area());
                Console.WriteLine("Perimetro: {0}", forma.Perimetro());
                return;
            }
        }
    }
}
