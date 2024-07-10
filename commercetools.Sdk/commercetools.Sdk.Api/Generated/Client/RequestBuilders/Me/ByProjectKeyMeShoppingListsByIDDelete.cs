using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeShoppingListsByIDDelete : ApiMethod<ByProjectKeyMeShoppingListsByIDDelete>, IApiMethod<ByProjectKeyMeShoppingListsByIDDelete, commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyMeShoppingListsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyMeShoppingListsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeShoppingListsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeShoppingListsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeShoppingListsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyMeShoppingListsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/me/shopping-lists/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public ByProjectKeyMeShoppingListsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyMeShoppingListsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
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

    }
}
