using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Payments
{

    public partial class ByProjectKeyPaymentsByIDDelete : ApiMethod<ByProjectKeyPaymentsByIDDelete>, IApiMethod<ByProjectKeyPaymentsByIDDelete, commercetools.Sdk.Api.Models.Payments.IPayment>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyPaymentsByIDDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyPaymentsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyPaymentsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyPaymentsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyPaymentsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyPaymentsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyPaymentsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/payments/{ID}";
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

        public ByProjectKeyPaymentsByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyPaymentsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyPaymentsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Payments.IPayment> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Payments.IPayment>(requestMessage, cancellationToken);
        }

    }
}
