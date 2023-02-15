using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.AssociateRoles
{

    public partial class ByProjectKeyAssociateRolesByIDGet : ApiMethod<ByProjectKeyAssociateRolesByIDGet>, IApiMethod<ByProjectKeyAssociateRolesByIDGet, commercetools.Sdk.Api.Models.AssociateRoles.IAssociateRole>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyAssociateRolesByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyAssociateRolesByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyAssociateRolesByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyAssociateRolesByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/associate-roles/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyAssociateRolesByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.AssociateRoles.IAssociateRole> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.AssociateRoles.IAssociateRole>(requestMessage, cancellationToken);
        }

    }
}
