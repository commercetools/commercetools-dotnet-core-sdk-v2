using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories
{

    public partial class ByProjectKeyTaxCategoriesByIDPost : ApiMethod<ByProjectKeyTaxCategoriesByIDPost>, IApiMethod<ByProjectKeyTaxCategoriesByIDPost, commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyTaxCategoriesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyTaxCategoriesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyTaxCategoriesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyTaxCategoriesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.TaxCategories.ITaxCategoryUpdate TaxCategoryUpdate;

        public ByProjectKeyTaxCategoriesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.TaxCategories.ITaxCategoryUpdate taxCategoryUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.TaxCategoryUpdate = taxCategoryUpdate;
            this.RequestUrl = $"/{ProjectKey}/tax-categories/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTaxCategoriesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(TaxCategoryUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
