using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AssociateRoles
{

    public partial class ByProjectKeyAssociateRolesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyAssociateRolesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyAssociateRolesKeyByKeyGet Get()
        {
            return new ByProjectKeyAssociateRolesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyAssociateRolesKeyByKeyHead Head()
        {
            return new ByProjectKeyAssociateRolesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyAssociateRolesKeyByKeyPost Post(commercetools.Sdk.Api.Models.AssociateRoles.IAssociateRoleUpdate associateRoleUpdate)
        {
            return new ByProjectKeyAssociateRolesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, associateRoleUpdate);
        }

        public ByProjectKeyAssociateRolesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyAssociateRolesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
