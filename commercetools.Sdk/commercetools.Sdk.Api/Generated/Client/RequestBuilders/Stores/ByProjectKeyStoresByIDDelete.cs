using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Stores
{

    public partial class ByProjectKeyStoresByIDDelete : ApiMethod<ByProjectKeyStoresByIDDelete>, IApiMethod<ByProjectKeyStoresByIDDelete, commercetools.Sdk.Api.Models.Stores.IStore>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyStoresByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyStoresByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStoresByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStoresByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStoresByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyStoresByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/stores/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStoresByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyStoresByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Stores.IStore> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Stores.IStore>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Stores.IStore>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Stores.IStore>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
