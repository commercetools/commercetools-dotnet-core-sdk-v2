using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Reviews
{
    public partial class ByProjectKeyReviewsByIDDelete : ApiMethod<ByProjectKeyReviewsByIDDelete>, IApiMethod<ByProjectKeyReviewsByIDDelete, commercetools.Sdk.Api.Models.Reviews.IReview>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyReviewsByIDDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyReviewsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyReviewsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyReviewsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyReviewsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyReviewsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyReviewsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/reviews/{ID}";
        }

        public List<string> GetDataErasure()
        {
            return this.GetQueryParam("dataErasure");
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyReviewsByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyReviewsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyReviewsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Reviews.IReview> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Reviews.IReview>(requestMessage);
        }

    }
}
