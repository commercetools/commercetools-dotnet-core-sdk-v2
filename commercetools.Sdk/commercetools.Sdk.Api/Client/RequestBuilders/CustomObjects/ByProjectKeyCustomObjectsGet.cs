using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Models;
using commercetools.Sdk.Api.Models.CustomObjects;
using commercetools.Sdk.Api.Predicates.Query.CustomObjects;

namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{
    public partial class ByProjectKeyCustomObjectsGet : IPagedQueryResourceRequest<ByProjectKeyCustomObjectsGet, ICustomObjectPagedQueryResponse, CustomObjectQueryBuilderDsl>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeyCustomObjectsGet,
        commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>
    {
        public async Task<IResourcePagedQueryResponse<GenericCustomObject<T>>> ExecuteAsync<T>(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<ResourcePagedQueryResponse<GenericCustomObject<T>>>(requestMessage, cancellationToken);
        }


        public async Task<IApiResponse<IResourcePagedQueryResponse<GenericCustomObject<T>>>> SendAsync<T>(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<ResourcePagedQueryResponse<GenericCustomObject<T>>>(requestMessage, cancellationToken);

        }
    }
}