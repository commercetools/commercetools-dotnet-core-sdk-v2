using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ProductProjections
{
    public class ByProjectKeyProductProjectionsSuggestTest : RequestBuilderParentTests
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
                   .Suggest()
                   .Get()
                   .WithSearchKeywords("locale", "searchKeywords.locale")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/suggest?searchKeywords.locale=searchKeywords.locale",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Suggest()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/suggest?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Suggest()
                   .Get()
                   .WithFuzzy(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/suggest?fuzzy=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Suggest()
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/suggest?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductProjections()
                   .Suggest()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/product-projections/suggest",
               }
       };
        }
    }
}
