using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.BusinessUnits
{
    public class ByProjectKeyBusinessUnitsSearchTest : RequestBuilderParentTests
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
                   .Search()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/business-units/search",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .BusinessUnits()
                   .Search()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/business-units/search",
               }
       };
        }
    }
}
