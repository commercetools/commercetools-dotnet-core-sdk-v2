using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportSinks
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyImportSinksRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyImportSinksRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyImportSinksPost Post(commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkDraft importSinkDraft)
        {
            return new ByProjectKeyImportSinksPost(ApiHttpClient, SerializerService, ProjectKey, importSinkDraft);
        }

        public ByProjectKeyImportSinksGet Get()
        {
            return new ByProjectKeyImportSinksGet(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyImportSinksByImportSinkKeyRequestBuilder WithImportSinkKeyValue(string importSinkKey)
        {
            return new ByProjectKeyImportSinksByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
        }
    }
}
