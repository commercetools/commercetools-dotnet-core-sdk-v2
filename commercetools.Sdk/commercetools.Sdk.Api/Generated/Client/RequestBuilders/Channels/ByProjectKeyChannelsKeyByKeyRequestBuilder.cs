using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyChannelsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyChannelsKeyByKeyGet Get()
        {
            return new ByProjectKeyChannelsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyChannelsKeyByKeyHead Head()
        {
            return new ByProjectKeyChannelsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyChannelsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Channels.IChannelUpdate channelUpdate)
        {
            return new ByProjectKeyChannelsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, channelUpdate);
        }

        public ByProjectKeyChannelsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyChannelsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
