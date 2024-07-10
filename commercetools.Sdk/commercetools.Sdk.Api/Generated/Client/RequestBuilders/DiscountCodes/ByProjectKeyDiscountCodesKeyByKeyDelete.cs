using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesKeyByKeyDelete : ApiMethod<ByProjectKeyDiscountCodesKeyByKeyDelete>, IApiMethod<ByProjectKeyDiscountCodesKeyByKeyDelete, commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyDiscountCodesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyDiscountCodesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyDiscountCodesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyDiscountCodesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyDiscountCodesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyDiscountCodesKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyDiscountCodesKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/discount-codes/key={Key}";
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

        public ByProjectKeyDiscountCodesKeyByKeyDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyDiscountCodesKeyByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyDiscountCodesKeyByKeyDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
