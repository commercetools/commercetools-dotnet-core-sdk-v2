using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeQuoteRequestsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyMeQuoteRequestsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyMeQuoteRequestsKeyByKeyGet Get()
        {
            return new ByProjectKeyMeQuoteRequestsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMeQuoteRequestsKeyByKeyHead Head()
        {
            return new ByProjectKeyMeQuoteRequestsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMeQuoteRequestsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Me.IMyQuoteRequestUpdate myQuoteRequestUpdate)
        {
            return new ByProjectKeyMeQuoteRequestsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myQuoteRequestUpdate);
        }

        public ByProjectKeyMeQuoteRequestsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyMeQuoteRequestsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
