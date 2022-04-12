using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Models.Common;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariants
{
    public partial class ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet : ApiMethod<ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }


        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet(IClient apiHttpClient, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.RequestUrl = $"/{ProjectKey}/product-variants/importSinkKey={ImportSinkKey}/import-operations";
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

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet WithLimit(decimal limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet WithOffset(decimal offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet WithResourceKey(string resourceKey)
        {
            return this.AddQueryParam("resourceKey", resourceKey);
        }

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet WithState(IProcessingState state)
        {
            return this.AddQueryParam("state", state.JsonName);
        }

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyImportOperationsGet WithDebug(bool debug)
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
