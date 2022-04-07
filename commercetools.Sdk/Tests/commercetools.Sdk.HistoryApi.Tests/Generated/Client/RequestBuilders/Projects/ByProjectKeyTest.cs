using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.HistoryApi.Tests.Client.RequestBuilders.Projects
{
    public class ByProjectKeyTest : RequestBuilderParentTests
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
                   .Get()
                   .WithResourceType(commercetools.Sdk.HistoryApi.Models.ChangeHistories.IChangeHistoryResourceType.FindEnum("resourceType"))
                   .Build(),
                   "Get",
                   "/test_projectKey?resourceType=resourceType",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithDateFrom("date.from")
                   .Build(),
                   "Get",
                   "/test_projectKey?date.from=date.from",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithDateTo("date.to")
                   .Build(),
                   "Get",
                   "/test_projectKey?date.to=date.to",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithUserId("userId")
                   .Build(),
                   "Get",
                   "/test_projectKey?userId=userId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithType("type")
                   .Build(),
                   "Get",
                   "/test_projectKey?type=type",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithClientId("clientId")
                   .Build(),
                   "Get",
                   "/test_projectKey?clientId=clientId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithResourceId("resourceId")
                   .Build(),
                   "Get",
                   "/test_projectKey?resourceId=resourceId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithSource("source")
                   .Build(),
                   "Get",
                   "/test_projectKey?source=source",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithChanges("changes")
                   .Build(),
                   "Get",
                   "/test_projectKey?changes=changes",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithStores("stores")
                   .Build(),
                   "Get",
                   "/test_projectKey?stores=stores",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithCustomerId("customerId")
                   .Build(),
                   "Get",
                   "/test_projectKey?customerId=customerId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithExcludePlatformInitiatedChanges(commercetools.Sdk.HistoryApi.Models.ChangeHistories.IPlatformInitiatedChange.FindEnum("excludePlatformInitiatedChanges"))
                   .Build(),
                   "Get",
                   "/test_projectKey?excludePlatformInitiatedChanges=excludePlatformInitiatedChanges",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .WithExpand(true)
                   .Build(),
                   "Get",
                   "/test_projectKey?expand=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey",
               }
       };
        }
    }
}
