using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportSinks
{
    public partial class ByProjectKeyImportSinksGet : ApiMethod<ByProjectKeyImportSinksGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyImportSinksGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/import-sinks";
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

        public ByProjectKeyImportSinksGet WithLimit(double limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyImportSinksGet WithOffset(double offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyImportSinksGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }


        public async Task<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkPagedResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkPagedResponse>(requestMessage);
        }

    }
}
