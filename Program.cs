using System.Net.Http;
using System.Text.Json;

class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();

        string url = "https://catfact.ninja/fact";

        string json = await client.GetStringAsync(url);

        CatFactResponse? resposta = JsonSerializer.Deserialize<CatFactResponse>(json);

        Console.WriteLine("Fato sobre Gatos:");

        if (resposta != null)
        {
            Console.WriteLine(resposta.fact);
        }
    }
}

class CatFactResponse
{
    public string? fact { get; set; }
    public int length { get; set; }
}
