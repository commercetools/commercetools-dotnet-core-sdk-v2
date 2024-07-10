using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes
{

    public partial class ByProjectKeyStagedQuotesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyStagedQuotesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyStagedQuotesByIDGet Get()
        {
            return new ByProjectKeyStagedQuotesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStagedQuotesByIDHead Head()
        {
            return new ByProjectKeyStagedQuotesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStagedQuotesByIDPost Post(commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteUpdate stagedQuoteUpdate)
        {
            return new ByProjectKeyStagedQuotesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, stagedQuoteUpdate);
        }

        public ByProjectKeyStagedQuotesByIDDelete Delete()
        {
            return new ByProjectKeyStagedQuotesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
