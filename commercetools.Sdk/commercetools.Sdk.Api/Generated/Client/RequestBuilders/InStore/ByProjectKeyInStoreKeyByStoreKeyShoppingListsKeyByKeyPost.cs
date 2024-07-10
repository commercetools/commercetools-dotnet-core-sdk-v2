using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost, commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.ShoppingLists.IShoppingListUpdate ShoppingListUpdate;

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key, commercetools.Sdk.Api.Models.ShoppingLists.IShoppingListUpdate shoppingListUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
            this.ShoppingListUpdate = shoppingListUpdate;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/shopping-lists/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(ShoppingListUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
