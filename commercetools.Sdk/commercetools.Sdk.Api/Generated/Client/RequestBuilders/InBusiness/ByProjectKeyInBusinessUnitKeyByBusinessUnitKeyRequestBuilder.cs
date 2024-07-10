using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.InBusiness;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InBusiness
{

    public partial class ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string BusinessUnitKey { get; }

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string businessUnitKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.BusinessUnitKey = businessUnitKey;
        }



        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeRequestBuilder Me()
        {
            return new ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, BusinessUnitKey);
        }
    }
}
