using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ByProjectKeyMissingDataImagesPost : ApiMethod<ByProjectKeyMissingDataImagesPost>, IApiMethod<ByProjectKeyMissingDataImagesPost, commercetools.Sdk.MLApi.Models.Common.ITaskToken>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.MLApi.Models.MissingData.IMissingImagesSearchRequest MissingImagesSearchRequest;

        public ByProjectKeyMissingDataImagesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.MLApi.Models.MissingData.IMissingImagesSearchRequest missingImagesSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.MissingImagesSearchRequest = missingImagesSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/missing-data/images";
        }




        public async Task<commercetools.Sdk.MLApi.Models.Common.ITaskToken> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.Common.ITaskToken>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(MissingImagesSearchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
