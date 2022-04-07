using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.ImportContainers
{
    public class ByProjectKeyImportContainersByImportContainerKeyImportOperationsTest : RequestBuilderParentTests
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
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .WithLimit(0.26748633)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations?limit=0.26748633",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .WithOffset(0.7475848)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations?offset=0.7475848",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .WithResourceKey("resourceKey")
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations?resourceKey=resourceKey",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .WithState(commercetools.Sdk.ImportApi.Models.Common.IProcessingState.FindEnum("state"))
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations?state=state",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .WithDebug(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations?debug=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .ImportOperations()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-operations",
               }
       };
        }
    }
}
