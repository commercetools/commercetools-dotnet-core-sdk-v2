using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Reviews
{

    public partial class ByProjectKeyReviewsByIDPost : ApiMethod<ByProjectKeyReviewsByIDPost>, IApiMethod<ByProjectKeyReviewsByIDPost, commercetools.Sdk.Api.Models.Reviews.IReview>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyReviewsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyReviewsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyReviewsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyReviewsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Reviews.IReviewUpdate ReviewUpdate;

        public ByProjectKeyReviewsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Reviews.IReviewUpdate reviewUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ReviewUpdate = reviewUpdate;
            this.RequestUrl = $"/{ProjectKey}/reviews/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyReviewsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Reviews.IReview> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Reviews.IReview>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ReviewUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
