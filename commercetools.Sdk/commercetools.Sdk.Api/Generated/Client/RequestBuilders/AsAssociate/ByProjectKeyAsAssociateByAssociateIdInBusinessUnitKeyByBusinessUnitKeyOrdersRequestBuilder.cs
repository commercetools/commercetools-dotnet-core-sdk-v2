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

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string businessUnitKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersGet(ApiHttpClient, ProjectKey, AssociateId, BusinessUnitKey);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersHead Head()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersHead(ApiHttpClient, ProjectKey, AssociateId, BusinessUnitKey);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersPost Post(commercetools.Sdk.Api.Models.Orders.IOrderFromCartDraft orderFromCartDraft)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, orderFromCartDraft);
        }


        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersQuotesRequestBuilder OrderQuote()
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberRequestBuilder WithOrderNumber(string orderNumber)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, orderNumber);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, BusinessUnitKey, ID);
        }
    }
}
