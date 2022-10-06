using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.BusinessUnits
{
    public class ByProjectKeyBusinessUnitsTest : RequestBuilderParentTests
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
                   .BusinessUnits()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/business-units?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/business-units",
               }
       };
        }
    }
}
