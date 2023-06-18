public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Tamogtchi ");

        Console.WriteLine("Qual é seu nome?");
        string name = Console.ReadLine();

        Console.WriteLine("--------------Menu-----------------");

        Console.WriteLine(name + ", o que voce Deseja");
        Console.WriteLine(@"1 - Adotar um mascote virutal");

        Console.WriteLine(@"2 - ver os  mascote virutal");
        Console.WriteLine(@"3 - Sair");

        string funcao = Console.ReadLine();
        if (funcao == funcao)
        {
            escolha.dadosPor("1");
            escolha.dadosPor("2");
            escolha.dadosPor("3");
            Console.WriteLine("--------------Menu-----------------");

            Console.WriteLine(name + ", o que voce Deseja");
            Console.WriteLine(@"1 - Adotar um mascote virutal");

            Console.WriteLine(@"2 - ver os  mascote virutal");
            Console.WriteLine(@"3 - Sair");

            string funcao = Console.ReadLine();
            switch (funcao)
            {

                case "1":
                    funcao = Console.ReadLine();

                    escolha.dadosPork(funcao);
                    break;
                case "2":
                    escolha.dadosPor("1");
                    escolha.dadosPor("2");
                    escolha.dadosPor("3");

                    break;
                case "3":
                    break;

            }

        }

    }
}