using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Models.CustomObjects;

namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects;

public partial class ByProjectKeyCustomObjectsByContainerByKeyGet
{
    public async Task<GenericCustomObject<T>> ExecuteAsync<T>(CancellationToken cancellationToken = default)
    {
        var requestMessage = Build();
        return await ApiHttpClient.ExecuteAsync<GenericCustomObject<T>>(requestMessage, cancellationToken);
    }
    
    
    public async Task<IApiResponse<GenericCustomObject<T>>> SendAsync<T>(CancellationToken cancellationToken = default)
    {

        var requestMessage = Build();
        return await ApiHttpClient.SendAsync<GenericCustomObject<T>>(requestMessage, cancellationToken);

    }
}