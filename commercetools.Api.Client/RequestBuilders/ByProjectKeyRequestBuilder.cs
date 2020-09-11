using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Api.Client.RequestBuilders.Categories;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Json;

namespace commercetools.Api.Client.RequestBuilders
{
    public class ByProjectKeyRequestBuilder
    {
        public IClient ApiHttpClient { get; }
        public string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
        }

       
        #region endpoints
        public ByProjectKeyCategoriesRequestBuilder Categories()
        {
            return new ByProjectKeyCategoriesRequestBuilder(ApiHttpClient,ProjectKey);
        }
        #endregion
    }
}
