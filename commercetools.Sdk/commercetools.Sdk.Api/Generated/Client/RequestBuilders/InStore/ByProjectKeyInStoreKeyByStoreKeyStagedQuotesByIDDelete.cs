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
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete, commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }


        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete(IClient apiHttpClient, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/staged-quotes/{ID}";
        }

        public List<string> GetDataErasure()
        {
            return this.GetQueryParam("dataErasure");
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
