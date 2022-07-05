using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{

    public partial class ByProjectKeyZonesKeyByKeyPost : ApiMethod<ByProjectKeyZonesKeyByKeyPost>, IApiMethod<ByProjectKeyZonesKeyByKeyPost, commercetools.Sdk.Api.Models.Zones.IZone>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyZonesKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyZonesKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyZonesKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyZonesKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.Zones.IZoneUpdate ZoneUpdate;

        public ByProjectKeyZonesKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.Zones.IZoneUpdate zoneUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.ZoneUpdate = zoneUpdate;
            this.RequestUrl = $"/{ProjectKey}/zones/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyZonesKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Zones.IZone> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Zones.IZone>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ZoneUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
