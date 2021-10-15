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


namespace commercetools.ImportApi.Client.RequestBuilders.ImportSinks
{
    public partial class ByProjectKeyImportSinksByImportSinkKeyPut : ApiMethod<ByProjectKeyImportSinksByImportSinkKeyPut>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Put;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.ImportApi.Models.Importsinks.IImportSinkUpdateDraft ImportSinkUpdateDraft;

        public ByProjectKeyImportSinksByImportSinkKeyPut(IClient apiHttpClient, string projectKey, string importSinkKey, commercetools.ImportApi.Models.Importsinks.IImportSinkUpdateDraft importSinkUpdateDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.ImportSinkUpdateDraft = importSinkUpdateDraft;
            this.RequestUrl = $"/{ProjectKey}/import-sinks/{ImportSinkKey}";
        }




        public async Task<commercetools.ImportApi.Models.Importsinks.IImportSink> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importsinks.IImportSink>(requestMessage);
        }

    }
}
