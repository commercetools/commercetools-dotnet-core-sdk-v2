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
    public partial class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }


        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet(IClient apiHttpClient, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/shopping-lists";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Api.Models.ShoppingLists.IShoppingListPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShoppingLists.IShoppingListPagedQueryResponse>(requestMessage);
        }

    }
}
