using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalFlowsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        private string ID { get; }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalFlowsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string businessUnitKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
            this.ID = id;
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalFlowsByIDGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalFlowsByIDGet(ApiHttpClient, ProjectKey, AssociateId, BusinessUnitKey, ID);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalFlowsByIDPost Post(commercetools.Sdk.Api.Models.ApprovalFlows.IApprovalFlowUpdate approvalFlowUpdate)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalFlowsByIDPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, ID, approvalFlowUpdate);
        }

    }
}
