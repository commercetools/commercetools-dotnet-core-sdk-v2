using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesPost : ApiMethod<ByProjectKeyCategoriesPost>
    {
        public IClient ApiHttpClient { get; }

        public string ProjectKey { get; }

        public CategoryDraft CategoryDraft { get; }

        public override HttpMethod Method => HttpMethod.Post;


        public ByProjectKeyCategoriesPost(IClient apiHttpClient, string projectKey, CategoryDraft categoryDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.CategoryDraft = categoryDraft;
            this.RequestUrl = $"/{ProjectKey}/categories";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCategoriesPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            //replace with seralizer service
            var body = JsonSerializer.Serialize(CategoryDraft);
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
