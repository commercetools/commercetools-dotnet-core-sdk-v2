using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    public partial class ByProjectKeyMissingDataPricesPost : ApiMethod<ByProjectKeyMissingDataPricesPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.MLApi.Models.MissingData.IMissingPricesSearchRequest MissingPricesSearchRequest;

        public ByProjectKeyMissingDataPricesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.MLApi.Models.MissingData.IMissingPricesSearchRequest missingPricesSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.MissingPricesSearchRequest = missingPricesSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/missing-data/prices";
        }




        public async Task<commercetools.Sdk.MLApi.Models.Common.ITaskToken> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.Common.ITaskToken>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(MissingPricesSearchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
