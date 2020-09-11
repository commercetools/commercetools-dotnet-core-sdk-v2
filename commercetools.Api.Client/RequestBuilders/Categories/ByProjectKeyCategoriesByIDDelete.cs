using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesByIDDelete : ApiMethod<ByProjectKeyCategoriesByIDDelete>
    {
        public IClient ApiHttpClient { get; }

        public string ProjectKey { get; }

        public string ID { get; }

        public override HttpMethod Method => HttpMethod.Delete;


        public ByProjectKeyCategoriesByIDDelete(IClient apiHttpClient, string projectKey, string id)
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
        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public ByProjectKeyCategoriesByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyCategoriesByIDDelete WithVersion(string expand)
        {
            return this.AddQueryParam("version", expand);
        }

        public async Task<Category> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<Category>(requestMessage);
        }
    }
}
