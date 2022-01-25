using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.ProductSelections
{
    public class ByProjectKeyProductSelectionsKeyByKeyProductsTest : RequestBuilderParentTests
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
                   .ProductSelections()
                   .WithKey("test_key")
                   .Products()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections/key=test_key/products?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .WithKey("test_key")
                   .Products()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections/key=test_key/products?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .WithKey("test_key")
                   .Products()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections/key=test_key/products?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .WithKey("test_key")
                   .Products()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections/key=test_key/products?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .WithKey("test_key")
                   .Products()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections/key=test_key/products",
               }
       };
        }
    }
}
