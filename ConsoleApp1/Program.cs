using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Processo principal para criar um novo monstro
            char formatoCabeca = EscolherFormatoCabeca();
            char[] caracteristicasFaciais = IdentificarCaracteristicasFacial();
            char classificacaoMonstro = CalcularPredominanciaCaracteristicas(caracteristicasFaciais);
            DescreverMonstro(classificacaoMonstro);
        }

        public static char EscolherFormatoCabeca()
        {
            Console.WriteLine("Escolha o formato da cabeça para o novo monstro: Franken digite F, Zombos digite Z, Happy digite H");
            char formatoCabeca = Console.ReadLine()[0];

            if (formatoCabeca == 'F' || formatoCabeca == 'Z' || formatoCabeca == 'H')
            {
                return formatoCabeca;
            }
            else
            {
                Console.WriteLine("Formato de cabeça inválido. Tente novamente.");
                return EscolherFormatoCabeca();
            }
        }

        public static char[] IdentificarCaracteristicasFacial()
        {
            Console.WriteLine("Identifique as características faciais predominantes para o novo monstro:");
            string caracteristicasFaciais = Console.ReadLine();
            return caracteristicasFaciais.ToCharArray();
        }

        public static char CalcularPredominanciaCaracteristicas(char[] caracteristicasFaciais)
        {
            bool wackus = caracteristicasFaciais.Contains('o') && caracteristicasFaciais.Contains('l') && caracteristicasFaciais.Contains('h');
            bool vegitas = caracteristicasFaciais.Contains('d') && caracteristicasFaciais.Contains('n');
            bool spritem = caracteristicasFaciais.Contains('m') && caracteristicasFaciais.Contains('s') && caracteristicasFaciais.Contains('r');

            if (wackus)
            {
                return 'W';
            }
            else if (vegitas)
            {
                return 'V';
            }
            else if (spritem)
            {
                return 'S';
            }
            else
            {
                return 'N'; // Nula
            }
        }

        public static void DescreverMonstro(char classificacaoMonstro)
        {
            if (classificacaoMonstro == 'N')
            {
                Console.WriteLine("Não foi possível classificar o novo monstro.");
            }
            else if (classificacaoMonstro == 'W')
            {
                Console.WriteLine("Novo monstro tem formato de cabeça Franken e predominância de características Wackus.");
            }
            else if (classificacaoMonstro == 'V')
            {
                Console.WriteLine("Novo monstro tem formato de cabeça Zombos e predominância de características Vegitas.");
            }
            else if (classificacaoMonstro == 'S')
            {
                Console.WriteLine("Novo monstro tem formato de cabeça Happy e predominância de características Spritem.");
            }
        }
    }
}