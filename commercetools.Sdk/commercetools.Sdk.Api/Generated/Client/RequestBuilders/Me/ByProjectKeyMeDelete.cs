using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeDelete : ApiMethod<ByProjectKeyMeDelete>, IApiMethod<ByProjectKeyMeDelete, commercetools.Sdk.Api.Models.Customers.ICustomer>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyMeDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyMeDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }


        public ByProjectKeyMeDelete(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/me";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public ByProjectKeyMeDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomer> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage, cancellationToken);
        }

    }
}
