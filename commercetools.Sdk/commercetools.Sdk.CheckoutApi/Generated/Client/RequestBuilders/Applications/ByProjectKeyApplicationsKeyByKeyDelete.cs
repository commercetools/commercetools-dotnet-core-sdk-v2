using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsKeyByKeyDelete : ApiMethod<ByProjectKeyApplicationsKeyByKeyDelete>, IApiMethod<ByProjectKeyApplicationsKeyByKeyDelete, commercetools.Sdk.CheckoutApi.Models.Applications.IApplication>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_applicationsTrait<ByProjectKeyApplicationsKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.CheckoutApi.Models.Applications.IApplication Application;

        public ByProjectKeyApplicationsKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key, commercetools.Sdk.CheckoutApi.Models.Applications.IApplication application)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.Application = application;
            this.RequestUrl = $"/{ProjectKey}/applications/key={Key}";
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
