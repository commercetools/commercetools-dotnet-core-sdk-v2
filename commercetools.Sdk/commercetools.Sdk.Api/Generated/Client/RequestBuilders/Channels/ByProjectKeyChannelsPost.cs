using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsPost : ApiMethod<ByProjectKeyChannelsPost>, IApiMethod<ByProjectKeyChannelsPost, commercetools.Sdk.Api.Models.Channels.IChannel>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyChannelsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyChannelsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyChannelsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Channels.IChannelDraft ChannelDraft;

        public ByProjectKeyChannelsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Channels.IChannelDraft channelDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ChannelDraft = channelDraft;
            this.RequestUrl = $"/{ProjectKey}/channels";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyChannelsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Channels.IChannel> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Channels.IChannel>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ChannelDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
