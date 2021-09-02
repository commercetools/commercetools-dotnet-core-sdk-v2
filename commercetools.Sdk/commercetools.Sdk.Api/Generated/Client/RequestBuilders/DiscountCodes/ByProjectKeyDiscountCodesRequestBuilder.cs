using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.DiscountCodes;

namespace commercetools.Api.Client.RequestBuilders.DiscountCodes
{

    public class ByProjectKeyDiscountCodesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyDiscountCodesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyDiscountCodesGet Get()
        {
            return new ByProjectKeyDiscountCodesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyDiscountCodesPost Post(commercetools.Api.Models.DiscountCodes.IDiscountCodeDraft discountCodeDraft)
        {
            return new ByProjectKeyDiscountCodesPost(ApiHttpClient, SerializerService, ProjectKey, discountCodeDraft);
        }


        public ByProjectKeyDiscountCodesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyDiscountCodesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
