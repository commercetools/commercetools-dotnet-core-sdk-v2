using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.ProductSelections
{
    public partial class ByProjectKeyProductSelectionsPost : ApiMethod<ByProjectKeyProductSelectionsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Api.Models.ProductSelections.IProductSelectionDraft ProductSelectionDraft;

        public ByProjectKeyProductSelectionsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.ProductSelections.IProductSelectionDraft productSelectionDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ProductSelectionDraft = productSelectionDraft;
            this.RequestUrl = $"/{ProjectKey}/product-selections";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductSelectionsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.ProductSelections.IProductSelection> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ProductSelections.IProductSelection>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ProductSelectionDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
