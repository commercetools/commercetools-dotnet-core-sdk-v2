using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Transactions
{

    public partial class ByProjectKeyTransactionsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyTransactionsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyTransactionsPost Post(commercetools.Sdk.CheckoutApi.Models.Transactions.ITransactionDraft transactionDraft)
        {
            return new ByProjectKeyTransactionsPost(ApiHttpClient, SerializerService, ProjectKey, transactionDraft);
        }


        public ByProjectKeyTransactionsByIdRequestBuilder WithId(string id)
        {
            return new ByProjectKeyTransactionsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, id);
        }

        public ByProjectKeyTransactionsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyTransactionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
