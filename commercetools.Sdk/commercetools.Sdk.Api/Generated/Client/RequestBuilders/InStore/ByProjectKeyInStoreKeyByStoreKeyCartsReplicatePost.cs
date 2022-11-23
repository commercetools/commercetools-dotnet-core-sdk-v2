using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost, commercetools.Sdk.Api.Models.Carts.ICart>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private commercetools.Sdk.Api.Models.Carts.IReplicaCartDraft ReplicaCartDraft;

        public ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Sdk.Api.Models.Carts.IReplicaCartDraft replicaCartDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ReplicaCartDraft = replicaCartDraft;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/carts/replicate";
        }




        public async Task<commercetools.Sdk.Api.Models.Carts.ICart> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Carts.ICart>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ReplicaCartDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
