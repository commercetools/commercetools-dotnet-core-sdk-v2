using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Stores
{

    public partial class ByProjectKeyStoresByIDGet : ApiMethod<ByProjectKeyStoresByIDGet>, IApiMethod<ByProjectKeyStoresByIDGet, commercetools.Sdk.Api.Models.Stores.IStore>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStoresByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStoresByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStoresByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyStoresByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/stores/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStoresByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Stores.IStore> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Stores.IStore>(requestMessage, cancellationToken);
        }

    }
}
