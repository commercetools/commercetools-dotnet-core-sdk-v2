using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.Api.Tests;
using commercetools.Sdk.Api.Models;
using commercetools.Sdk.Api.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.InStore
{
    public class ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesTest : RequestBuilderParentTests
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
                   .WithProductId("test_productID")
                   .ProductTailoring()
                   .Images()
                   .Post(null)
                   .WithFilename("filename")
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/test_productID/product-tailoring/images?filename=filename",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductId("test_productID")
                   .ProductTailoring()
                   .Images()
                   .Post(null)
                   .WithVariant(7)
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/test_productID/product-tailoring/images?variant=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductId("test_productID")
                   .ProductTailoring()
                   .Images()
                   .Post(null)
                   .WithSku("sku")
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/test_productID/product-tailoring/images?sku=sku",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductId("test_productID")
                   .ProductTailoring()
                   .Images()
                   .Post(null)
                   .WithStaged(true)
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/test_productID/product-tailoring/images?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Products()
                   .WithProductId("test_productID")
                   .ProductTailoring()
                   .Images()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/products/test_productID/product-tailoring/images",
               }
       };
        }
    }
}
