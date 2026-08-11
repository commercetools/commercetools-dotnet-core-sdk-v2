using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.InStore
{
    public class ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDVariantAttributesTest : RequestBuilderParentTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void WithMethods(HttpRequestMessage request, string httpMethod, string uri)
        {
            Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
            Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
        }

        public static IEnumerable<object[]> GetData()
        {
            return new List<object[]> {
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .ProductProjections()
                   .WithId("test_ID")
                   .VariantAttributes()
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/product-projections/test_ID/variant-attributes?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .ProductProjections()
                   .WithId("test_ID")
                   .VariantAttributes()
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/product-projections/test_ID/variant-attributes?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .ProductProjections()
                   .WithId("test_ID")
                   .VariantAttributes()
                   .Get()
                   .WithFilterAttributes("filter[attributes]")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/product-projections/test_ID/variant-attributes?filter[attributes]=filter%5Battributes%5D",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .ProductProjections()
                   .WithId("test_ID")
                   .VariantAttributes()
                   .Get()
                   .WithFilterSupplyChannels("filter[supplyChannels]")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/product-projections/test_ID/variant-attributes?filter[supplyChannels]=filter%5BsupplyChannels%5D",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .ProductProjections()
                   .WithId("test_ID")
                   .VariantAttributes()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/product-projections/test_ID/variant-attributes",
               }
       };
        }
    }
}
