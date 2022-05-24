using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{
    public partial class ByProjectKeyMePaymentsByIDDelete : ApiMethod<ByProjectKeyMePaymentsByIDDelete>, IApiMethod<ByProjectKeyMePaymentsByIDDelete, commercetools.Sdk.Api.Models.Me.IMyPayment>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyMePaymentsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyMePaymentsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMePaymentsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMePaymentsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMePaymentsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyMePaymentsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/me/payments/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMePaymentsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyMePaymentsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Me.IMyPayment> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Me.IMyPayment>(requestMessage);
        }

    }
}
