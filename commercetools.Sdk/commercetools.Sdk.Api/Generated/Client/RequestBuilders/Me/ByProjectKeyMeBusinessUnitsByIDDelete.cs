using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeBusinessUnitsByIDDelete : ApiMethod<ByProjectKeyMeBusinessUnitsByIDDelete>, IApiMethod<ByProjectKeyMeBusinessUnitsByIDDelete, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyMeBusinessUnitsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyMeBusinessUnitsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeBusinessUnitsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeBusinessUnitsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeBusinessUnitsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyMeBusinessUnitsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/me/business-units/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeBusinessUnitsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyMeBusinessUnitsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
