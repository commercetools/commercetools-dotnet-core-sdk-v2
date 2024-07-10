using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.ImportApi.Tests;
using commercetools.Sdk.ImportApi.Models;
using commercetools.Sdk.ImportApi.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.ImportContainers
{
    public class ByProjectKeyImportContainersByImportContainerKeyImportSummariesTest : RequestBuilderParentTests
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
                   .ImportSummaries()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-containers/test_importContainerKey/import-summaries",
               }
       };
        }
    }
}
