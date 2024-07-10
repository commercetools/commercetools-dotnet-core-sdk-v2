using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeQuotesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMeQuotesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMeQuotesByIDGet Get()
        {
            return new ByProjectKeyMeQuotesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeQuotesByIDHead Head()
        {
            return new ByProjectKeyMeQuotesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeQuotesByIDPost Post(commercetools.Sdk.Api.Models.Me.IMyQuoteUpdate myQuoteUpdate)
        {
            return new ByProjectKeyMeQuotesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myQuoteUpdate);
        }

    }
}
