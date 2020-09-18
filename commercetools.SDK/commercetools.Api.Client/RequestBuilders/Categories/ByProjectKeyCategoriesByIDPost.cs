using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesByIDPost : ApiMethod<ByProjectKeyCategoriesByIDPost>
    {
        public IClient ApiHttpClient { get; }

        public string ProjectKey { get; }

        public string ID { get; }

        public CategoryUpdate CategoryUpdate { get; }

        public override HttpMethod Method => HttpMethod.Post;


        public ByProjectKeyCategoriesByIDPost(IClient apiHttpClient, string projectKey, string id, CategoryUpdate categoryUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.CategoryUpdate = categoryUpdate;
            this.RequestUrl = $"/{ProjectKey}/categories/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCategoriesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            //replace with seralizer service
            var body = JsonSerializer.Serialize(CategoryUpdate);
            if(!string.IsNullOrEmpty(body))
            {
                request.Content = new StringContent(body);
            }
            return request;
        }

        public async Task<Category> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<Category>(requestMessage);
        }
    }
}
