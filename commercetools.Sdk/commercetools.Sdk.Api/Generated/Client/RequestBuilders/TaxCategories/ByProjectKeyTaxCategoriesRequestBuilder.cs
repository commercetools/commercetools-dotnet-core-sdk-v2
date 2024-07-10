using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories
{

    public partial class ByProjectKeyTaxCategoriesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyTaxCategoriesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyTaxCategoriesGet Get()
        {
            return new ByProjectKeyTaxCategoriesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyTaxCategoriesHead Head()
        {
            return new ByProjectKeyTaxCategoriesHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyTaxCategoriesPost Post(commercetools.Sdk.Api.Models.TaxCategories.ITaxCategoryDraft taxCategoryDraft)
        {
            return new ByProjectKeyTaxCategoriesPost(ApiHttpClient, SerializerService, ProjectKey, taxCategoryDraft);
        }


        public ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyTaxCategoriesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyTaxCategoriesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
