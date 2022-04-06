using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Models.Common;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{
    public partial class ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet : ApiMethod<ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }


        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet(IClient apiHttpClient, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.RequestUrl = $"/{ProjectKey}/import-containers/{ImportContainerKey}/import-operations";
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetResourceKey()
        {
            return this.GetQueryParam("resourceKey");
        }

        public List<string> GetState()
        {
            return this.GetQueryParam("state");
        }

        public List<string> GetDebug()
        {
            return this.GetQueryParam("debug");
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet WithLimit(double limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet WithOffset(double offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet WithResourceKey(string resourceKey)
        {
            return this.AddQueryParam("resourceKey", resourceKey);
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet WithState(IProcessingState state)
        {
            return this.AddQueryParam("state", state.JsonName);
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsGet WithDebug(bool debug)
        {
            return this.AddQueryParam("debug", debug.ToString());
        }


        public async Task<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperationPagedResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperationPagedResponse>(requestMessage);
        }

    }
}
