using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Api.Models;
using commercetools.Api.Models.Common;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.Zones
{
    public class ByProjectKeyZonesByIDTest : RequestBuilderParentTests
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
                   .Zones()
                   .WithId("test_ID")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/zones/test_ID?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Zones()
                   .WithId("test_ID")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/zones/test_ID",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Zones()
                   .WithId("test_ID")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/zones/test_ID?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Zones()
                   .WithId("test_ID")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/zones/test_ID",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Zones()
                   .WithId("test_ID")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/zones/test_ID?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Zones()
                   .WithId("test_ID")
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/zones/test_ID?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Zones()
                   .WithId("test_ID")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/zones/test_ID",
               }
       };
        }
    }
}