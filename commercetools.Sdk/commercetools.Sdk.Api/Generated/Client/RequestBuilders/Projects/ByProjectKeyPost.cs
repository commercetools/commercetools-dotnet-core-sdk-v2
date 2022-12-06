using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Projects
{

    public partial class ByProjectKeyPost : ApiMethod<ByProjectKeyPost>, IApiMethod<ByProjectKeyPost, commercetools.Sdk.Api.Models.Projects.IProject>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Projects.IProjectUpdate ProjectUpdate;

        public ByProjectKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Projects.IProjectUpdate projectUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ProjectUpdate = projectUpdate;
            this.RequestUrl = $"/{ProjectKey}";
        }




        public async Task<commercetools.Sdk.Api.Models.Projects.IProject> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Projects.IProject>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ProjectUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
