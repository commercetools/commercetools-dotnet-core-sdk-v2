using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeQuoteRequestsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMeQuoteRequestsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMeQuoteRequestsByIDGet Get()
        {
            return new ByProjectKeyMeQuoteRequestsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeQuoteRequestsByIDHead Head()
        {
            return new ByProjectKeyMeQuoteRequestsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeQuoteRequestsByIDPost Post(commercetools.Sdk.Api.Models.Me.IMyQuoteRequestUpdate myQuoteRequestUpdate)
        {
            return new ByProjectKeyMeQuoteRequestsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myQuoteRequestUpdate);
        }

        public ByProjectKeyMeQuoteRequestsByIDDelete Delete()
        {
            return new ByProjectKeyMeQuoteRequestsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
