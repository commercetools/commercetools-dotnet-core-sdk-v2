using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{

    public partial class ByProjectKeyZonesByIDPost : ApiMethod<ByProjectKeyZonesByIDPost>, IApiMethod<ByProjectKeyZonesByIDPost, commercetools.Sdk.Api.Models.Zones.IZone>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyZonesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyZonesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyZonesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyZonesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Zones.IZoneUpdate ZoneUpdate;

        public ByProjectKeyZonesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Zones.IZoneUpdate zoneUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ZoneUpdate = zoneUpdate;
            this.RequestUrl = $"/{ProjectKey}/zones/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyZonesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Zones.IZone> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Zones.IZone>(requestMessage, cancellationToken);
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
