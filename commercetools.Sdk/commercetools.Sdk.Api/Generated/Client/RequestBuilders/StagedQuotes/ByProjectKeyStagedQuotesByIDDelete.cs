using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes
{

    public partial class ByProjectKeyStagedQuotesByIDDelete : ApiMethod<ByProjectKeyStagedQuotesByIDDelete>, IApiMethod<ByProjectKeyStagedQuotesByIDDelete, commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStagedQuotesByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStagedQuotesByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyStagedQuotesByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/staged-quotes/{ID}";
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

        public ByProjectKeyStagedQuotesByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyStagedQuotesByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyStagedQuotesByIDDelete WithExpand(string expand)
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
