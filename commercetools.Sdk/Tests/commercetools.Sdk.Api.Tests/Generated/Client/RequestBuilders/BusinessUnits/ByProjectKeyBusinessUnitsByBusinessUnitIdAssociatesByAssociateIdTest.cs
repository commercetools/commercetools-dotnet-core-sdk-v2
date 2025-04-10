using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.BusinessUnits
{
    public class ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdTest : RequestBuilderParentTests
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
                   .WithBusinessUnitIdValueAssociatesWithAssociateIdValue("test_businessUnitId", "test_associateId")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units/test_businessUnitId/associates/test_associateId",
               }
       };
        }
    }
}
