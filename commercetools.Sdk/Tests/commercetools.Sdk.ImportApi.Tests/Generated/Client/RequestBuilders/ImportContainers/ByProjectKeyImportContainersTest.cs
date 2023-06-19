using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.ImportContainers
{
    public class ByProjectKeyImportContainersTest : RequestBuilderParentTests
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
                   .ImportContainers()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/import-containers",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .Get()
                   .WithLimit((decimal)0.26748633)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers?limit=0.26748633",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .Get()
                   .WithOffset((decimal)0.7475848)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers?offset=0.7475848",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers",
               }
       };
        }
    }
}
