using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.InStore
{
    public class ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsTest : RequestBuilderParentTests
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
                   .VariantProjections()
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceCustomerGroupAssignments("priceCustomerGroupAssignments")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCustomerGroupAssignments=priceCustomerGroupAssignments",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPriceRecurrencePolicy("priceRecurrencePolicy")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceRecurrencePolicy=priceRecurrencePolicy",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithFilterAttributes("filter[attributes]")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?filter[attributes]=filter%5Battributes%5D",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithStaged(true)
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceCurrency("priceCurrency")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCurrency=priceCurrency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceCountry("priceCountry")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCountry=priceCountry",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceCustomerGroup("priceCustomerGroup")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceCustomerGroup=priceCustomerGroup",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithPriceChannel("priceChannel")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?priceChannel=priceChannel",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithLocaleProjection("localeProjection")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?localeProjection=localeProjection",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .WithFilterAttributes("filter[attributes]")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections?filter[attributes]=filter%5Battributes%5D",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .VariantProjections()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/variant-projections",
               }
       };
        }
    }
}
