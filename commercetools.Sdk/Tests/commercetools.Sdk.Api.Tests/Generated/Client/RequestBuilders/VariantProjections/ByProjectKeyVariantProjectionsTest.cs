using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.VariantProjections
{
    public class ByProjectKeyVariantProjectionsTest : RequestBuilderParentTests
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
                   .VariantProjections()
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCustomerGroupAssignments("priceCustomerGroupAssignments")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?priceCustomerGroupAssignments=priceCustomerGroupAssignments",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceRecurrencePolicy("priceRecurrencePolicy")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?priceRecurrencePolicy=priceRecurrencePolicy",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithFilterAttributes("filter[attributes]")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?filter[attributes]=filter%5Battributes%5D",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/variant-projections",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithStaged(true)
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .WithFilterAttributes("filter[attributes]")
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections?filter[attributes]=filter%5Battributes%5D",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .VariantProjections()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/variant-projections",
               }
       };
        }
    }
}
