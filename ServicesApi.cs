using System.Net;
using Newtonsoft.Json;

public class ServicesApi
{


    public void dadosPork(string name)
    {
        var requisicaoWeb = WebRequest.CreateHttp($"https://pokeapi.co/api/v2/pokemon/{name}");
        requisicaoWeb.Method = "GET";
        requisicaoWeb.UserAgent = "RequisicaoWebDemo";

        using (var resposta = requisicaoWeb.GetResponse())
        {
            var streamDados = resposta.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            object objResponse = reader.ReadToEnd();

            var post = JsonConvert.DeserializeObject<Pokemon>(objResponse.ToString());

            Console.WriteLine($"Nome do Pokemon: " + post.name +
            "\r\n Altura: " + post.height
            + "\r\n Peso: " + post.weight
            + "\r\n Habilidade");

            foreach (var item in post.abilities)
            {
                Console.WriteLine(item.Ability.name);

            }
            Console.ReadLine();
            streamDados.Close();
            resposta.Close();
        }
        Console.ReadKey();

    }

    public void qualPokemonEscolher()
    {
        var requisicaoWeb = WebRequest.CreateHttp($"https://pokeapi.co/api/v2/pokemon/");
        requisicaoWeb.Method = "GET";
        requisicaoWeb.UserAgent = "RequisicaoWebDemo";

        using (var resposta = requisicaoWeb.GetResponse())
        {
            var streamDados = resposta.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            object objResponse = reader.ReadToEnd();

          var post = JsonConvert.DeserializeObject<Pokemon>(objResponse.ToString());

      

            foreach (var item in objResponse.ToString())
            {
                Console.Write(item.ToString());
            }            
             
            Console.ReadLine();
            streamDados.Close();
            resposta.Close();
        }
        Console.ReadKey();
    }
}