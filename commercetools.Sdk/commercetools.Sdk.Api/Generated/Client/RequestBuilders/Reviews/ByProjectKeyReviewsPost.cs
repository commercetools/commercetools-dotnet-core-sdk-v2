using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Reviews
{

    public partial class ByProjectKeyReviewsPost : ApiMethod<ByProjectKeyReviewsPost>, IApiMethod<ByProjectKeyReviewsPost, commercetools.Sdk.Api.Models.Reviews.IReview>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyReviewsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyReviewsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyReviewsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Reviews.IReviewDraft ReviewDraft;

        public ByProjectKeyReviewsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Reviews.IReviewDraft reviewDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ReviewDraft = reviewDraft;
            this.RequestUrl = $"/{ProjectKey}/reviews";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyReviewsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Reviews.IReview> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Reviews.IReview>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ReviewDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
