using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsByIDHead : ApiMethod<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsByIDHead>, IApiMethod<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsByIDHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsByIDHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsByIDHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        private string ID { get; }


        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsByIDHead(IClient apiHttpClient, string projectKey, string associateId, string businessUnitKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/as-associate/{AssociateId}/in-business-unit/key={BusinessUnitKey}/carts/{ID}";
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
