using System;
using System.Net.Http;
using commercetools.Api.Models.Categorys;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public class ByProjectKeyCategoriesRequestBuilder
    {
        public IClient ApiHttpClient { get; }

        public string ProjectKey { get;}

        public ByProjectKeyCategoriesRequestBuilder(IClient apiHttpClient,string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCategoriesGet Get()
        {
            return new ByProjectKeyCategoriesGet(ApiHttpClient, ProjectKey);
        }        
        public ByProjectKeyCategoriesPost Post(CategoryDraft categoryDraft)
        {
            return new ByProjectKeyCategoriesPost(ApiHttpClient, ProjectKey, categoryDraft);
        }
        public ByProjectKeyCategoriesByIDRequestBuilder WithId(string id)
        {
            return new ByProjectKeyCategoriesByIDRequestBuilder(ApiHttpClient, ProjectKey, id);
        }
        //withKey
    }
}
