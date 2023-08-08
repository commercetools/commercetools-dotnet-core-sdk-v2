using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using ZeroQL;

namespace commercetools.Sdk.GraphQL.Api;

public static class GraphQlClientExtensions
{
    // ReSharper disable once InconsistentNaming
    public static GraphQLClient GraphQLClient(this ProjectApiRoot client)
    {
        return new GraphQLClient(client.ApiHttpClient.ToHandler(client.ProjectKey));
    }

    // ReSharper disable once InconsistentNaming
    public static GraphQLClient GraphQLClient(this IClient client, string projectKey)
    {
        return new GraphQLClient(client.ToHandler(projectKey));
    }
    
    private static IHttpHandler ToHandler(this IClient client, string projectKey)
    {
        return new ClientHandler(client, projectKey);
    }
}

internal class ClientHandler : IHttpHandler
{
    private readonly IClient _client;
    private readonly Uri _graphQlUri;

    public ClientHandler(IClient client, string projectKey)
    {
        _client = client;
        _graphQlUri = new Uri($"/{projectKey}/graphql", UriKind.Relative);
    }

    public void Dispose()
    {
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.RequestUri =  _graphQlUri;
        return await _client.SendAsAsync(request, cancellationToken);
    }
}