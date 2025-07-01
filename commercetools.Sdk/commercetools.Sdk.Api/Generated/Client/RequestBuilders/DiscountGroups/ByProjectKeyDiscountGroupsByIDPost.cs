using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountGroups
{

    public partial class ByProjectKeyDiscountGroupsByIDPost : ApiMethod<ByProjectKeyDiscountGroupsByIDPost>, IApiMethod<ByProjectKeyDiscountGroupsByIDPost, commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroup>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyDiscountGroupsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyDiscountGroupsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyDiscountGroupsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyDiscountGroupsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroupUpdate DiscountGroupUpdate;

        public ByProjectKeyDiscountGroupsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroupUpdate discountGroupUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.DiscountGroupUpdate = discountGroupUpdate;
            this.RequestUrl = $"/{ProjectKey}/discount-groups/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyDiscountGroupsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroup> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroup>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroup>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroup>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(DiscountGroupUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
