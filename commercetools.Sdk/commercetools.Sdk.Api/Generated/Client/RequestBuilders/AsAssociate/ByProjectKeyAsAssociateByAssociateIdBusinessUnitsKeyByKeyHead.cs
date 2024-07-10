using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyHead : ApiMethod<ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyHead>, IApiMethod<ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string Key { get; }


        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyHead(IClient apiHttpClient, string projectKey, string associateId, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/as-associate/{AssociateId}/business-units/key={Key}";
        }




        public async Task<string> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            return await ExecuteAsJsonAsync(cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<string>> SendAsync(CancellationToken cancellationToken = default)
        {

            return await SendAsJsonAsync(cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
