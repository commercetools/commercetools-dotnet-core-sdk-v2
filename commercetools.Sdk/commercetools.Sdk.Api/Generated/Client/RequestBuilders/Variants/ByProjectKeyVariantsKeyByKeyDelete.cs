using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsKeyByKeyDelete : ApiMethod<ByProjectKeyVariantsKeyByKeyDelete>, IApiMethod<ByProjectKeyVariantsKeyByKeyDelete, commercetools.Sdk.Api.Models.Variants.IVariant>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyVariantsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyVariantsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyVariantsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantsKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyVariantsKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/variants/key={Key}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyVariantsKeyByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyVariantsKeyByKeyDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Variants.IVariant> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariant>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariant>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariant>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
