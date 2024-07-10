using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductDiscounts
{

    public partial class ByProjectKeyProductDiscountsMatchingRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductDiscountsMatchingRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductDiscountsMatchingPost Post(commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscountMatchQuery productDiscountMatchQuery)
        {
            return new ByProjectKeyProductDiscountsMatchingPost(ApiHttpClient, SerializerService, ProjectKey, productDiscountMatchQuery);
        }

    }
}
