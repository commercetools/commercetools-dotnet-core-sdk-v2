using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.Api.Tests;
using commercetools.Sdk.Api.Models;
using commercetools.Sdk.Api.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.StandalonePrices
{
    public class ByProjectKeyStandalonePricesKeyByKeyTest : RequestBuilderParentTests
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
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/standalone-prices/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/standalone-prices/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/standalone-prices/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/standalone-prices/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/standalone-prices/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/standalone-prices/key=test_key?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/standalone-prices/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .StandalonePrices()
                   .WithKey("test_key")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/standalone-prices/key=test_key",
               }
       };
        }
    }
}
