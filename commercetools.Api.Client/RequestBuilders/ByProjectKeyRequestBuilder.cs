using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Api.Client.RequestBuilders.Categories;
using commercetools.Api.Client.RequestBuilders.Channels;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Json;

namespace commercetools.Api.Client.RequestBuilders
{
    public class ByProjectKeyRequestBuilder
    {
        public HttpClient ApiHttpClient { get; }
        public string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(HttpClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
        }

       
        #region endpoints
        public ByProjectKeyCategoriesRequestBuilder Categories()
        {
            return new ByProjectKeyCategoriesRequestBuilder(ProjectKey);
        }
        public ByProjectKeyChannelsRequestBuilder Channels()
        {
            return new ByProjectKeyChannelsRequestBuilder();
        }
        #endregion
    }
}
