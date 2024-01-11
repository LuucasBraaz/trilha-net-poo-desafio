using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Solicitar ao usuário os dados para Nokia
            Console.WriteLine("Digite os dados para o Nokia:");
            Nokia nokiaPhone = DadosDeEntradaNokia();

            // Teste de instalação de aplicativo no Nokia
            TestarSmartphone(nokiaPhone, "Ifood");

            // Solicitar ao usuário os dados para iPhone
            Console.WriteLine("Digite os dados para o iPhone:");
            Iphone iphone = DadosDeEntradaIphone();

            // Teste de instalação de aplicativo no iPhone
            TestarSmartphone(iphone, "Facebook");
        }

        static Nokia DadosDeEntradaNokia()
        {
            Console.Write("Número: ");
            string numero = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("IMEI: ");
            string imei = Console.ReadLine();

            Console.Write("Memória: ");
            int memoria = int.Parse(Console.ReadLine());

            return new Nokia(numero, modelo, imei, memoria);
        }

        static Iphone DadosDeEntradaIphone()
        {
            Console.Write("Número: ");
            string numero = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("IMEI: ");
            string imei = Console.ReadLine();

            Console.Write("Memória: ");
            int memoria = int.Parse(Console.ReadLine());

            return new Iphone(numero, modelo, imei, memoria);
        }

        static void TestarSmartphone(Smartphone smartphone, string aplicativo)
        {
            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo(aplicativo);
            Console.WriteLine();
        }
    }
}