using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        private string ID { get; }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string businessUnitKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
            this.ID = id;
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDGet(ApiHttpClient, ProjectKey, AssociateId, BusinessUnitKey, ID);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDPost Post(commercetools.Sdk.Api.Models.ApprovalRules.IApprovalRuleUpdate approvalRuleUpdate)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, ID, approvalRuleUpdate);
        }

    }
}
