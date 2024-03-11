namespace RiotGamesApi.Infrastructure.Clients;

public class RiotClient(HttpClient httpClient) : IRiotClient
{

    public async Task<HttpResponseMessage> GetSomeDataAsync()
    {
        //TODO: tomar base url de .env
        return await httpClient.GetAsync("url_de_la_api");
    }
}