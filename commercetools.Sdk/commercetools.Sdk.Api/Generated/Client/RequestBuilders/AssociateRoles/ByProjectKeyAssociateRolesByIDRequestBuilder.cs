using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AssociateRoles
{

    public partial class ByProjectKeyAssociateRolesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyAssociateRolesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyAssociateRolesByIDGet Get()
        {
            return new ByProjectKeyAssociateRolesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyAssociateRolesByIDHead Head()
        {
            return new ByProjectKeyAssociateRolesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyAssociateRolesByIDPost Post(commercetools.Sdk.Api.Models.AssociateRoles.IAssociateRoleUpdate associateRoleUpdate)
        {
            return new ByProjectKeyAssociateRolesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, associateRoleUpdate);
        }

        public ByProjectKeyAssociateRolesByIDDelete Delete()
        {
            return new ByProjectKeyAssociateRolesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
