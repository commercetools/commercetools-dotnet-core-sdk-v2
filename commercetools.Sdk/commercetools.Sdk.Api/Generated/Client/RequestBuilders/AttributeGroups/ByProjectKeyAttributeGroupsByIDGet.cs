using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups
{

    public partial class ByProjectKeyAttributeGroupsByIDGet : ApiMethod<ByProjectKeyAttributeGroupsByIDGet>, IApiMethod<ByProjectKeyAttributeGroupsByIDGet, commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroup>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyAttributeGroupsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyAttributeGroupsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyAttributeGroupsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyAttributeGroupsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/attribute-groups/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyAttributeGroupsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroup> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroup>(requestMessage, cancellationToken);
        }

    }
}
