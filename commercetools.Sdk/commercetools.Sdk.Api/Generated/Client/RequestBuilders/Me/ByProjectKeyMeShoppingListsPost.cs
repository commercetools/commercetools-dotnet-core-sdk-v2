using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeShoppingListsPost : ApiMethod<ByProjectKeyMeShoppingListsPost>, IApiMethod<ByProjectKeyMeShoppingListsPost, commercetools.Sdk.Api.Models.ShoppingLists.IShoppingList>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeShoppingListsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyMeShoppingListsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeShoppingListsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Me.IMyShoppingListDraft MyShoppingListDraft;

        public ByProjectKeyMeShoppingListsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Me.IMyShoppingListDraft myShoppingListDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.MyShoppingListDraft = myShoppingListDraft;
            this.RequestUrl = $"/{ProjectKey}/me/shopping-lists";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeShoppingListsPost WithExpand(string expand)
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
                var body = this.SerializerService.Serialize(MyShoppingListDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
