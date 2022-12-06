using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{

    public partial class ByProjectKeyCustomObjectsByContainerByKeyGet : ApiMethod<ByProjectKeyCustomObjectsByContainerByKeyGet>, IApiMethod<ByProjectKeyCustomObjectsByContainerByKeyGet, commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomObjectsByContainerByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomObjectsByContainerByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomObjectsByContainerByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Container { get; }

        private string Key { get; }


        public ByProjectKeyCustomObjectsByContainerByKeyGet(IClient apiHttpClient, string projectKey, string container, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Container = container;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/custom-objects/{Container}/{Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomObjectsByContainerByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>(requestMessage, cancellationToken);
        }

    }
}
