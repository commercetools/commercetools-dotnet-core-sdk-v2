using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersByIDDelete : ApiMethod<ByProjectKeyOrdersByIDDelete>, IApiMethod<ByProjectKeyOrdersByIDDelete, commercetools.Sdk.Api.Models.Orders.IOrder>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyOrdersByIDDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyOrdersByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyOrdersByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyOrdersByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyOrdersByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/orders/{ID}";
        }

        public List<string> GetDataErasure()
        {
            return this.GetQueryParam("dataErasure");
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyOrdersByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyOrdersByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyOrdersByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Orders.IOrder> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage);
        }

    }
}
