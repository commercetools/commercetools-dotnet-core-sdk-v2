using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.InStore
{
    public class ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringTest : RequestBuilderParentTests
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
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductKey("test_productKey")
                   .ProductTailoring()
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/products/key=test_productKey/product-tailoring",
               }
       };
        }
    }
}
