using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ProductSelections
{
    public class ByProjectKeyProductSelectionsTest : RequestBuilderParentTests
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
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/product-selections",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/product-selections?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/product-selections",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/product-selections?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ProductSelections()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/product-selections",
               }
       };
        }
    }
}
