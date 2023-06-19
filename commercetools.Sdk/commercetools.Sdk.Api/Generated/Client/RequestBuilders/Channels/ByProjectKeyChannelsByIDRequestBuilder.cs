using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyChannelsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyChannelsByIDGet Get()
        {
            return new ByProjectKeyChannelsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyChannelsByIDPost Post(commercetools.Sdk.Api.Models.Channels.IChannelUpdate channelUpdate)
        {
            return new ByProjectKeyChannelsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, channelUpdate);
        }

        public ByProjectKeyChannelsByIDDelete Delete()
        {
            return new ByProjectKeyChannelsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
