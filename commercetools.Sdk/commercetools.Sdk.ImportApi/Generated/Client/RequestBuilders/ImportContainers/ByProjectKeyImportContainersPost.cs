using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportContainers
{
    public partial class ByProjectKeyImportContainersPost : ApiMethod<ByProjectKeyImportContainersPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.ImportApi.Models.Importcontainers.IImportContainerDraft ImportContainerDraft;

        public ByProjectKeyImportContainersPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.ImportApi.Models.Importcontainers.IImportContainerDraft importContainerDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerDraft = importContainerDraft;
            this.RequestUrl = $"/{ProjectKey}/import-containers";
        }




        public async Task<commercetools.ImportApi.Models.Importcontainers.IImportContainer> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importcontainers.IImportContainer>(requestMessage);
        }

        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ImportContainerDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }
    }
}
