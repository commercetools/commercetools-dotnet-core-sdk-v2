using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Customers;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersGet Get()
        {
            return new ByProjectKeyCustomersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCustomersHead Head()
        {
            return new ByProjectKeyCustomersHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCustomersPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerDraft customerDraft)
        {
            return new ByProjectKeyCustomersPost(ApiHttpClient, SerializerService, ProjectKey, customerDraft);
        }


        public ByProjectKeyCustomersPasswordTokenByPasswordTokenRequestBuilder WithPasswordToken(string passwordToken)
        {
            return new ByProjectKeyCustomersPasswordTokenByPasswordTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, passwordToken);
        }

        public ByProjectKeyCustomersEmailTokenByEmailTokenRequestBuilder WithEmailToken(string emailToken)
        {
            return new ByProjectKeyCustomersEmailTokenByEmailTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, emailToken);
        }

        public ByProjectKeyCustomersEmailTokenRequestBuilder EmailToken()
        {
            return new ByProjectKeyCustomersEmailTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersEmailConfirmRequestBuilder EmailConfirm()
        {
            return new ByProjectKeyCustomersEmailConfirmRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersPasswordRequestBuilder Password()
        {
            return new ByProjectKeyCustomersPasswordRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersPasswordResetRequestBuilder PasswordReset()
        {
            return new ByProjectKeyCustomersPasswordResetRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersPasswordTokenRequestBuilder PasswordToken()
        {
            return new ByProjectKeyCustomersPasswordTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyCustomersKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyCustomersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyCustomersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyCustomersSearchRequestBuilder Search()
        {
            return new ByProjectKeyCustomersSearchRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersSearchIndexingStatusRequestBuilder SearchIndexingStatus()
        {
            return new ByProjectKeyCustomersSearchIndexingStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
