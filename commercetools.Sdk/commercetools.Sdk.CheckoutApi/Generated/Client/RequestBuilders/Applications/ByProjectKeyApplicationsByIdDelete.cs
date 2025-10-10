using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsByIdDelete : ApiMethod<ByProjectKeyApplicationsByIdDelete>, IApiMethod<ByProjectKeyApplicationsByIdDelete, commercetools.Sdk.CheckoutApi.Models.Applications.IApplication>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_applicationsTrait<ByProjectKeyApplicationsByIdDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Id { get; }

        private commercetools.Sdk.CheckoutApi.Models.Applications.IApplication Application;

        public ByProjectKeyApplicationsByIdDelete(IClient apiHttpClient, string projectKey, string id, commercetools.Sdk.CheckoutApi.Models.Applications.IApplication application)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.Application = application;
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

    }
}
