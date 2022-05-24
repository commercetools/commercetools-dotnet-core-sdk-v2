using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{
    public partial class ByProjectKeyZonesByIDGet : ApiMethod<ByProjectKeyZonesByIDGet>, IApiMethod<ByProjectKeyZonesByIDGet, commercetools.Sdk.Api.Models.Zones.IZone>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyZonesByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyZonesByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyZonesByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyZonesByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/zones/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyZonesByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Zones.IZone> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Zones.IZone>(requestMessage);
        }

    }
}
