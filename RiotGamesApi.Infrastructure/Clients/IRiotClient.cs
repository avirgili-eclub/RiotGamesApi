namespace RiotGamesApi.Infrastructure.Clients;

public interface IRiotClient
{
    Task<HttpResponseMessage> GetSomeDataAsync();
}