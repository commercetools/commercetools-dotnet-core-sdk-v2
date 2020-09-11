using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesByIDGet : ApiMethod<ByProjectKeyCategoriesByIDGet>
    {
        public IClient ApiHttpClient { get; }

        public string ProjectKey { get; }

        public string ID { get; }

        public override HttpMethod Method => HttpMethod.Get;


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

        public async Task<Category> ExecuteAsync()
        {
            if(ApiHttpClient == null)
            {
                throw new ArgumentNullException("apiHttpClient cannot be null");
            }
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<Category>(requestMessage);
        }
    }
}
