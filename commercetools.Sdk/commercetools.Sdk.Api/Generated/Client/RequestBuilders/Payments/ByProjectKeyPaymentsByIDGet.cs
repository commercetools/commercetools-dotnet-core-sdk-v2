using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Payments
{

    public partial class ByProjectKeyPaymentsByIDGet : ApiMethod<ByProjectKeyPaymentsByIDGet>, IApiMethod<ByProjectKeyPaymentsByIDGet, commercetools.Sdk.Api.Models.Payments.IPayment>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyPaymentsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyPaymentsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyPaymentsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyPaymentsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/payments/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyPaymentsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Payments.IPayment> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Payments.IPayment>(requestMessage);
        }

    }
}
