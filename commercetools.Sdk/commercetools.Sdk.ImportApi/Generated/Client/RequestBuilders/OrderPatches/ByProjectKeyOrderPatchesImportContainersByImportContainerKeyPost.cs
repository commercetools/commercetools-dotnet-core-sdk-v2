using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.OrderPatches
{
    public partial class ByProjectKeyOrderPatchesImportContainersByImportContainerKeyPost : ApiMethod<ByProjectKeyOrderPatchesImportContainersByImportContainerKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.ImportApi.Models.Importrequests.IOrderPatchImportRequest OrderPatchImportRequest;

        public ByProjectKeyOrderPatchesImportContainersByImportContainerKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey, commercetools.ImportApi.Models.Importrequests.IOrderPatchImportRequest orderPatchImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.OrderPatchImportRequest = orderPatchImportRequest;
            this.RequestUrl = $"/{ProjectKey}/order-patches/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importrequests.IImportResponse>(requestMessage);
        }

        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(OrderPatchImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }
    }
}
