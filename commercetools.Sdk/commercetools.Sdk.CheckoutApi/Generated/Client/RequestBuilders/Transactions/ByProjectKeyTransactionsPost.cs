using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Transactions
{

    public partial class ByProjectKeyTransactionsPost : ApiMethod<ByProjectKeyTransactionsPost>, IApiMethod<ByProjectKeyTransactionsPost, commercetools.Sdk.CheckoutApi.Models.Transactions.ITransaction>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_transactionsTrait<ByProjectKeyTransactionsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.CheckoutApi.Models.Transactions.ITransactionDraft TransactionDraft;

        public ByProjectKeyTransactionsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.CheckoutApi.Models.Transactions.ITransactionDraft transactionDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.TransactionDraft = transactionDraft;
            this.RequestUrl = $"/{ProjectKey}/transactions";
        }




        public async Task<commercetools.Sdk.CheckoutApi.Models.Transactions.ITransaction> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.Transactions.ITransaction>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.Transactions.ITransaction>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.Transactions.ITransaction>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(TransactionDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
