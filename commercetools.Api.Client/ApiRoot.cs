using System;
using System.Net.Http;
using commercetools.Api.Client.RequestBuilders;

namespace commercetools.Api.Client
{
    public class ApiRoot
    {
        private HttpClient Client { get; set; }
        public ApiRoot()
        {
            //Initalize httpClient

        }

        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(Client,projectKey);
        }
    }
}
