using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Api.Models;
using commercetools.Api.Models.Common;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.Products
{
    public class ByProjectKeyProductsTest : RequestBuilderParentTests
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
                   .Products()
                   .Get()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/products?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/products?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/products?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/products?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/products",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/products",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/products?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/products",
               }
       };
        }
    }
}
