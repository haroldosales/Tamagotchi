public class Program
{
    public static void Main(string[] args)
    {
        var escolhar = new ServicesApi();
        string? pokemon = "null";

        Console.WriteLine("Bem vindo ao Tamogtchi ");

        Console.WriteLine("Qual é seu nome?");
        string? name = Console.ReadLine();

        Console.WriteLine("--------------Menu-----------------");

        while (pokemon != "3")
        {
            Console.WriteLine(@"1 - Adotar um mascote virutal");
            Console.WriteLine(@"2 - ver os  mascote virutal");
            Console.WriteLine(@"3 - Sair");
            pokemon = Console.ReadLine();

            switch (pokemon)
            {

                case "1":
                    Console.WriteLine(name + ", o qual pokemon voce Deseja");

                    pokemon = Console.ReadLine();

                    escolhar.dadosPork(pokemon);
                    break;
                case "2":
                for(int i =1; i <=10; i++){
                    pokemon = i.ToString();

                           escolhar.OneOne(pokemon);
                }
                 
                    Console.WriteLine(name + ", o que voce Deseja");


                    break;
                case "3":

                    break;

            }



        }
    }
}