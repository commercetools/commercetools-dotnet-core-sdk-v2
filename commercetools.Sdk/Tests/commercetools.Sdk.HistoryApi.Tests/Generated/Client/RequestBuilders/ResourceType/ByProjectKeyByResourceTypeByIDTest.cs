using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.HistoryApi.Models;
using commercetools.HistoryApi.Models.Common;
using Xunit;

namespace commercetools.HistoryApi.Tests.Client.RequestBuilders.ResourceType
{
    public class ByProjectKeyByResourceTypeByIDTest : RequestBuilderParentTests
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
                   .WithIDValue("test_ID")
                   .Get()
                   .WithDateFrom("date.from")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?date.from=date.from",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithDateTo("date.to")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?date.to=date.to",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithUserId("userId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?userId=userId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithType("type")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?type=type",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithClientId("clientId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?clientId=clientId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithSource("source")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?source=source",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithChanges("changes")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?changes=changes",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithCustomerId("customerId")
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?customerId=customerId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithExcludePlatformInitiatedChanges(IPlatformInitiatedChange.FindEnum("excludePlatformInitiatedChanges"))
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?excludePlatformInitiatedChanges=excludePlatformInitiatedChanges",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .WithExpand(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID?expand=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .WithResourceTypeValue("test_resourceType")
                   .WithIDValue("test_ID")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/test_resourceType/test_ID",
               }
       };
        }
    }
}
