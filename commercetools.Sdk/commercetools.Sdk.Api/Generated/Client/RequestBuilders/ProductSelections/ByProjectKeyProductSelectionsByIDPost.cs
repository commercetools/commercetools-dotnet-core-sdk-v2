using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public partial class ByProjectKeyProductSelectionsByIDPost : ApiMethod<ByProjectKeyProductSelectionsByIDPost>, IApiMethod<ByProjectKeyProductSelectionsByIDPost, commercetools.Sdk.Api.Models.ProductSelections.IProductSelection>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyProductSelectionsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductSelectionsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductSelectionsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductSelectionsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionUpdate ProductSelectionUpdate;

        public ByProjectKeyProductSelectionsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionUpdate productSelectionUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ProductSelectionUpdate = productSelectionUpdate;
            this.RequestUrl = $"/{ProjectKey}/product-selections/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductSelectionsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductSelections.IProductSelection> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductSelection>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ProductSelections.IProductSelection>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductSelection>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(ProductSelectionUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
