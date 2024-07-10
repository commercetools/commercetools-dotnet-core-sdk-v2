using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups
{

    public partial class ByProjectKeyAttributeGroupsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyAttributeGroupsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyAttributeGroupsGet Get()
        {
            return new ByProjectKeyAttributeGroupsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyAttributeGroupsHead Head()
        {
            return new ByProjectKeyAttributeGroupsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyAttributeGroupsPost Post(commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroupDraft attributeGroupDraft)
        {
            return new ByProjectKeyAttributeGroupsPost(ApiHttpClient, SerializerService, ProjectKey, attributeGroupDraft);
        }


        public ByProjectKeyAttributeGroupsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyAttributeGroupsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyAttributeGroupsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyAttributeGroupsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
