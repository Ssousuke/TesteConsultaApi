using System.Net.Http;

class Program
{
    static async Task Main()
    {
        HttpClient httpClient = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
        var response = await httpClient.GetAsync("posts");
        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
            Console.WriteLine("" + content);
    }
}