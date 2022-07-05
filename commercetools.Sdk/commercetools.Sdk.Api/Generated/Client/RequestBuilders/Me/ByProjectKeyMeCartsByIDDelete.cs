using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeCartsByIDDelete : ApiMethod<ByProjectKeyMeCartsByIDDelete>, IApiMethod<ByProjectKeyMeCartsByIDDelete, commercetools.Sdk.Api.Models.Carts.ICart>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyMeCartsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyMeCartsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeCartsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeCartsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeCartsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyMeCartsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/me/carts/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeCartsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyMeCartsByIDDelete WithExpand(string expand)
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
