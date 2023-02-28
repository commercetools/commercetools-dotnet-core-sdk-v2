using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyChannelsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyChannelsGet Get()
        {
            return new ByProjectKeyChannelsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyChannelsPost Post(commercetools.Sdk.Api.Models.Channels.IChannelDraft channelDraft)
        {
            return new ByProjectKeyChannelsPost(ApiHttpClient, SerializerService, ProjectKey, channelDraft);
        }


        public ByProjectKeyChannelsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyChannelsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
