using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesByIDGet : ApiMethod<ByProjectKeyCategoriesByIDGet>, IApiMethod<ByProjectKeyCategoriesByIDGet, commercetools.Sdk.Api.Models.Categories.ICategory>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCategoriesByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCategoriesByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCategoriesByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyCategoriesByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/categories/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCategoriesByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Categories.ICategory> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Categories.ICategory>(requestMessage);
        }

    }
}
