public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Tamogtchi ");

        Console.WriteLine("Qual é seu nome?");
        string name = Console.ReadLine();
        Console.WriteLine("--------------Menu-----------------");

        Console.WriteLine(name + ", o que voce Deseja");

        Console.WriteLine(@"1 - Adotar um mascote virutal
                    2 - Ver os mascorte
                    3 - Sair");

        string escolhar = Console.ReadLine();
        var escolha = new ServicesApi();
       
            switch (escolhar)
            {
                case "1":
                    Console.WriteLine("--------------adotar um binhco-----------------");
                    Console.WriteLine(name + " digite o nome do pokemon que voce queira");
                    string x = Console.ReadLine();
                    escolha.dadosPork(x);
                    break;
                case "2":
                    Console.WriteLine("--------------qual  binhco-----------------");
                    Console.WriteLine("Bulbasaur");
                    Console.WriteLine("Ivysaur");
                    break;
            
                case "3":
                    Console.Clear();
                    break;

            }
        
      
        
    }

}
