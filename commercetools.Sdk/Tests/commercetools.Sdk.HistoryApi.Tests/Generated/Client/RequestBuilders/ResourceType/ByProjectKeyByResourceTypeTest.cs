using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Tests.Client.RequestBuilders.ResourceType
{
    public class ByProjectKeyByResourceTypeTest : RequestBuilderParentTests
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
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithDateFrom("date.from")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?date.from=date.from",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithDateTo("date.to")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?date.to=date.to",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithUserId("userId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?userId=userId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithType("type")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?type=type",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithClientId("clientId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?clientId=clientId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithResourceId("resourceId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?resourceId=resourceId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithSource("source")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?source=source",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithChanges("changes")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?changes=changes",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithStores("stores")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?stores=stores",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithCustomerId("customerId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?customerId=customerId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithExcludePlatformInitiatedChanges(commercetools.Sdk.HistoryApi.Models.ChangeHistories.IPlatformInitiatedChange.FindEnum("excludePlatformInitiatedChanges"))
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?excludePlatformInitiatedChanges=excludePlatformInitiatedChanges",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .WithExpand(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType?expand=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType",
               }
       };
        }
    }
}
