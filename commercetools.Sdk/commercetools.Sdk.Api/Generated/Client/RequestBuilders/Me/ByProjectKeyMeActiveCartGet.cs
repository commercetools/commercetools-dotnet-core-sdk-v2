using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeActiveCartGet : ApiMethod<ByProjectKeyMeActiveCartGet>, IApiMethod<ByProjectKeyMeActiveCartGet, commercetools.Sdk.Api.Models.Carts.ICart>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeActiveCartGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeActiveCartGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeActiveCartGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyMeActiveCartGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/me/active-cart";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeActiveCartGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Carts.ICart> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Carts.ICart>(requestMessage);
        }

    }
}
