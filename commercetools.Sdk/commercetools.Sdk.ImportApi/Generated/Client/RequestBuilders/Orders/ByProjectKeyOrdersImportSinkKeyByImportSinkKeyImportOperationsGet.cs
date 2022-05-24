using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Models.Common;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Orders
{
    public partial class ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet : ApiMethod<ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet>, IApiMethod<ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet, commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperationPagedResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_ordersTrait<ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }


        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet(IClient apiHttpClient, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.RequestUrl = $"/{ProjectKey}/orders/importSinkKey={ImportSinkKey}/import-operations";
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

        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet WithLimit(decimal limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet WithOffset(decimal offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet WithResourceKey(string resourceKey)
        {
            return this.AddQueryParam("resourceKey", resourceKey);
        }

        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet WithState(IProcessingState state)
        {
            return this.AddQueryParam("state", state.JsonName);
        }

        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsGet WithDebug(bool debug)
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
