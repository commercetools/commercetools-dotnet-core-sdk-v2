using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsByIDDelete : ApiMethod<ByProjectKeyChannelsByIDDelete>, IApiMethod<ByProjectKeyChannelsByIDDelete, commercetools.Sdk.Api.Models.Channels.IChannel>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyChannelsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyChannelsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyChannelsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyChannelsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyChannelsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyChannelsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/channels/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyChannelsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyChannelsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Channels.IChannel> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Channels.IChannel>(requestMessage, cancellationToken);
        }

    }
}
