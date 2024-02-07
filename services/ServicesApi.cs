using System.Net;
using System.Text.Json;

public class ServicesApi
{


    public void dadosPork(string name)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, name);
            var response = client.Send(request);

            var pok = JsonSerializer.Deserialize<Pokemon>(response.Content.ReadAsStringAsync().Result);
            Console.WriteLine($"Nome do Pokemon: " + pok.name +
                              "\r\n Altura: " + pok.height
                              + "\r\n Peso: " + pok.weight
                              + "\r\n Habilidade: " + pok.abilities.ToArray().ToString());


        }
    }

    public void OneOne(string name)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, name);
            var response = client.Send(request);

            var pok = JsonSerializer.Deserialize<Pokemon>(response.Content.ReadAsStringAsync().Result);
            Console.WriteLine(pok.name);


        }
    }

}
