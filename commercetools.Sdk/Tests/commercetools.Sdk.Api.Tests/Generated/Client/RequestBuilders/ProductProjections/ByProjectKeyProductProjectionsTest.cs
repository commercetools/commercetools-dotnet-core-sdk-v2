using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ProductProjections
{
    public class ByProjectKeyProductProjectionsTest : RequestBuilderParentTests
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
                   .ProductProjections()
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections",
               }
       };
        }
    }
}
