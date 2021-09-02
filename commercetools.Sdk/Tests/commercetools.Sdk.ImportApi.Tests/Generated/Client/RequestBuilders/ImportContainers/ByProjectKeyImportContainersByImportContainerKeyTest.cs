using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.ImportApi.Models;
using commercetools.ImportApi.Models.Common;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.ImportContainers
{
    public class ByProjectKeyImportContainersByImportContainerKeyTest : RequestBuilderParentTests
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
                   .Put(null)
                   .Build(),
                   "Put",
                   "/test_projectKey/import-containers/test_importContainerKey",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/import-containers/test_importContainerKey",
               }
       };
        }
    }
}
