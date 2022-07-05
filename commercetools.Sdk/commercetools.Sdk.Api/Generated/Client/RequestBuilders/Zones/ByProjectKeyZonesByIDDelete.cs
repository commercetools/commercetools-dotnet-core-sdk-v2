using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{

    public partial class ByProjectKeyZonesByIDDelete : ApiMethod<ByProjectKeyZonesByIDDelete>, IApiMethod<ByProjectKeyZonesByIDDelete, commercetools.Sdk.Api.Models.Zones.IZone>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyZonesByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyZonesByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyZonesByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyZonesByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyZonesByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyZonesByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/zones/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyZonesByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyZonesByIDDelete WithExpand(string expand)
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
