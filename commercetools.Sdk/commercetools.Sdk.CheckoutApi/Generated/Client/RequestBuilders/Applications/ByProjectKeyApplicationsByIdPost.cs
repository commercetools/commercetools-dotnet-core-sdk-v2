using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsByIdPost : ApiMethod<ByProjectKeyApplicationsByIdPost>, IApiMethod<ByProjectKeyApplicationsByIdPost, commercetools.Sdk.CheckoutApi.Models.Applications.IApplication>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_applicationsTrait<ByProjectKeyApplicationsByIdPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Id { get; }

        private commercetools.Sdk.CheckoutApi.Models.Applications.IApplicationUpdateActions ApplicationUpdateActions;

        public ByProjectKeyApplicationsByIdPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.CheckoutApi.Models.Applications.IApplicationUpdateActions applicationUpdateActions)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.ApplicationUpdateActions = applicationUpdateActions;
            this.RequestUrl = $"/{ProjectKey}/applications/{Id}";
        }




        public async Task<commercetools.Sdk.CheckoutApi.Models.Applications.IApplication> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.Applications.IApplication>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.Applications.IApplication>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.Applications.IApplication>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ApplicationUpdateActions);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
