using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.InStore;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerDraft customerDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenRequestBuilder WithPasswordToken(string passwordToken)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, passwordToken);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenRequestBuilder WithEmailToken(string emailToken)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, emailToken);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenRequestBuilder EmailToken()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmRequestBuilder EmailConfirm()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordRequestBuilder Password()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordResetRequestBuilder PasswordReset()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordResetRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenRequestBuilder PasswordToken()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
