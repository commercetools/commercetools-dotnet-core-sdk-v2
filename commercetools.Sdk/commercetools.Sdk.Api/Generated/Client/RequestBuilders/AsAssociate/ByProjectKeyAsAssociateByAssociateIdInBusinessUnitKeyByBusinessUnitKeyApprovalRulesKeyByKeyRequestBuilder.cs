using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        private string Key { get; }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string businessUnitKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
            this.Key = key;
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyGet(ApiHttpClient, ProjectKey, AssociateId, BusinessUnitKey, Key);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyPost Post(commercetools.Sdk.Api.Models.ApprovalRules.IApprovalRuleUpdate approvalRuleUpdate)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, Key, approvalRuleUpdate);
        }

    }
}
