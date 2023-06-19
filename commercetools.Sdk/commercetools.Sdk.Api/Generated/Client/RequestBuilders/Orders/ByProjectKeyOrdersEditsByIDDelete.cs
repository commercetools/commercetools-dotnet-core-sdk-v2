using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsByIDDelete : ApiMethod<ByProjectKeyOrdersEditsByIDDelete>, IApiMethod<ByProjectKeyOrdersEditsByIDDelete, commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyOrdersEditsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyOrdersEditsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyOrdersEditsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersEditsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersEditsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyOrdersEditsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/orders/edits/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyOrdersEditsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyOrdersEditsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
