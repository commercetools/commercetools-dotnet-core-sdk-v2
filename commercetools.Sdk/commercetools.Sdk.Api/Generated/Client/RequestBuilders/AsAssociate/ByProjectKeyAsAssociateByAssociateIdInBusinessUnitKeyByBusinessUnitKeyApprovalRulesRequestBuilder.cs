using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string businessUnitKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesGet(ApiHttpClient, ProjectKey, AssociateId, BusinessUnitKey);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesPost Post(commercetools.Sdk.Api.Models.ApprovalRules.IApprovalRuleDraft approvalRuleDraft)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, approvalRuleDraft);
        }


        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, ID);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyApprovalRulesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, key);
        }
    }
}
