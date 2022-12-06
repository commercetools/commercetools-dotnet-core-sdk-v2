using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsByIDGet : ApiMethod<ByProjectKeyChannelsByIDGet>, IApiMethod<ByProjectKeyChannelsByIDGet, commercetools.Sdk.Api.Models.Channels.IChannel>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyChannelsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyChannelsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyChannelsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyChannelsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/channels/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyChannelsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Channels.IChannel> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Channels.IChannel>(requestMessage, cancellationToken);
        }

    }
}
