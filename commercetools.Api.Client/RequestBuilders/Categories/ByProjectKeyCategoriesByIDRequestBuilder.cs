using System.Collections.Generic;
using System.Net.Http;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesByIDRequestBuilder
    {
        public IClient ApiHttpClient { get; }

        public string ProjectKey { get; }

        public string ID { get;}

        public ByProjectKeyCategoriesByIDRequestBuilder(IClient apiHttpClient, string projectKey,string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyCategoriesByIDGet Get()
        {
            return new ByProjectKeyCategoriesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyCategoriesByIDDelete Delete()
        {
            return new ByProjectKeyCategoriesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyCategoriesByIDPost Post(CategoryUpdate categoryUpdate)
        {
            return new ByProjectKeyCategoriesByIDPost(ApiHttpClient, ProjectKey, ID, categoryUpdate);
        }
    }
}
