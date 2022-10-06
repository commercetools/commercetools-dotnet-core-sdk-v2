using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsKeyByKeyPost : ApiMethod<ByProjectKeyBusinessUnitsKeyByKeyPost>, IApiMethod<ByProjectKeyBusinessUnitsKeyByKeyPost, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyBusinessUnitsKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyBusinessUnitsKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyBusinessUnitsKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyBusinessUnitsKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate BusinessUnitUpdate;

        public ByProjectKeyBusinessUnitsKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.BusinessUnitUpdate = businessUnitUpdate;
            this.RequestUrl = $"/{ProjectKey}/business-units/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyBusinessUnitsKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(BusinessUnitUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
