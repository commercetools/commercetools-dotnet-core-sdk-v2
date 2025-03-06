using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.BusinessUnits
{
    public class ByProjectKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdTest : RequestBuilderParentTests
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
                   .KeyWithKeyValueAssociatesWithAssociateIdValue("test_key", "test_associateId")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/business-units/key=test_key/associates/test_associateId",
               }
       };
        }
    }
}
