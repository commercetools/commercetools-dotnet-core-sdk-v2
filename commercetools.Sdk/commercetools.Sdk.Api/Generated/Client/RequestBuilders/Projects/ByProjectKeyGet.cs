using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Projects
{

    public partial class ByProjectKeyGet : ApiMethod<ByProjectKeyGet>, IApiMethod<ByProjectKeyGet, commercetools.Sdk.Api.Models.Projects.IProject>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}";
        }




        public async Task<commercetools.Sdk.Api.Models.Projects.IProject> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Projects.IProject>(requestMessage, cancellationToken);
        }

    }
}
