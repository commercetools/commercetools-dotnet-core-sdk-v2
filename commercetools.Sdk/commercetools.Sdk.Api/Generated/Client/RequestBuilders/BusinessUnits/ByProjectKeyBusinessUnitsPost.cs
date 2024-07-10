using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsPost : ApiMethod<ByProjectKeyBusinessUnitsPost>, IApiMethod<ByProjectKeyBusinessUnitsPost, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyBusinessUnitsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyBusinessUnitsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyBusinessUnitsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitDraft BusinessUnitDraft;

        public ByProjectKeyBusinessUnitsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitDraft businessUnitDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.BusinessUnitDraft = businessUnitDraft;
            this.RequestUrl = $"/{ProjectKey}/business-units";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyBusinessUnitsPost WithExpand(string expand)
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
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(BusinessUnitDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
