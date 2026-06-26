using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.Variants
{
    public class ByProjectKeyVariantsTest : RequestBuilderParentTests
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
                   .Variants()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/variants?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/variants",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/variants?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/variants",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/variants?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/variants",
               }
       };
        }
    }
}
