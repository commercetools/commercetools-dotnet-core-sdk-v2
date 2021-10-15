using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
    public partial class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }


        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyGet(IClient apiHttpClient, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/shopping-lists/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.ShoppingLists.IShoppingList> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShoppingLists.IShoppingList>(requestMessage);
        }

    }
}
