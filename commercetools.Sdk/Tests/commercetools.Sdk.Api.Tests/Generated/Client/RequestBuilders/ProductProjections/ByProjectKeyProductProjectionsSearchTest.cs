using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ProductProjections
{
    public class ByProjectKeyProductProjectionsSearchTest : RequestBuilderParentTests
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
                   .Search()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/product-projections/search",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithMarkMatchingVariants(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?markMatchingVariants=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithText("locale", "text.locale")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?text.locale=text.locale",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithFuzzy(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?fuzzy=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithFuzzyLevel(9)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?fuzzyLevel=9",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithFilterQuery("filter.query")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?filter.query=filter.query",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithFilter("filter")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?filter=filter",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithFacet("facet")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?facet=facet",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithFilterFacets("filter.facets")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?filter.facets=filter.facets",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithPriceCustomerGroupAssignments("priceCustomerGroupAssignments")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?priceCustomerGroupAssignments=priceCustomerGroupAssignments",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithPriceRecurrencePolicy("priceRecurrencePolicy")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?priceRecurrencePolicy=priceRecurrencePolicy",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .WithStoreProjection("storeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search?storeProjection=storeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Search()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/search",
               }
       };
        }
    }
}
