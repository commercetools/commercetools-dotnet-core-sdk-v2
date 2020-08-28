using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesGet : ApiMethod<ByProjectKeyCategoriesGet>
    {
        public HttpClient ApiHttpClient { get; }

        public string ProjectKey { get; }

        public string ID { get; }

        public override HttpMethod Method => HttpMethod.Get;


        public ByProjectKeyCategoriesGet(HttpClient apiHttpClient,string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/categories";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }
        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }
        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }
        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }
        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }


        public ByProjectKeyCategoriesGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }
        public ByProjectKeyCategoriesGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }
        public ByProjectKeyCategoriesGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }
        public ByProjectKeyCategoriesGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }
        public ByProjectKeyCategoriesGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }
        public ByProjectKeyCategoriesGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public async Task<CategoryPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            var result = await ApiHttpClient.SendAsync(requestMessage).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<CategoryPagedQueryResponse>(content);
        }
    }
}
