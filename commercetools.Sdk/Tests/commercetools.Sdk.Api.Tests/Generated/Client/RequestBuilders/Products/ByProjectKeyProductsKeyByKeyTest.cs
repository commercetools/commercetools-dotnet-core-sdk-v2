using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Api.Models;
using commercetools.Api.Models.Common;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.Products
{
    public class ByProjectKeyProductsKeyByKeyTest : RequestBuilderParentTests
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
                   .WithKey("test_key")
                   .Get()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/products/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/products/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/products/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithKey("test_key")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/products/key=test_key",
               }
       };
        }
    }
}
