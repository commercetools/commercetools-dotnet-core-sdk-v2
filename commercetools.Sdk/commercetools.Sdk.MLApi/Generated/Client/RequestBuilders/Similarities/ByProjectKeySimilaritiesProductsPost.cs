using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.MLApi.Client.RequestBuilders.Similarities
{
    public partial class ByProjectKeySimilaritiesProductsPost : ApiMethod<ByProjectKeySimilaritiesProductsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.MLApi.Models.SimilarProducts.ISimilarProductSearchRequest SimilarProductSearchRequest;

        public ByProjectKeySimilaritiesProductsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.MLApi.Models.SimilarProducts.ISimilarProductSearchRequest similarProductSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.SimilarProductSearchRequest = similarProductSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/similarities/products";
        }




        public async Task<commercetools.MLApi.Models.Common.ITaskToken> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.Common.ITaskToken>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(SimilarProductSearchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
