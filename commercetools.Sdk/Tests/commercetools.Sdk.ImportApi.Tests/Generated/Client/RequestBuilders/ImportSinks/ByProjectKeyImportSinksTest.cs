using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.ImportApi.Models;
using commercetools.ImportApi.Models.Common;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.ImportSinks
{
    public class ByProjectKeyImportSinksTest : RequestBuilderParentTests
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
                   .ImportSinks()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/import-sinks",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .Get()
                   .WithLimit(0.26748633)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-sinks?limit=0.26748633",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .Get()
                   .WithOffset(0.7475848)
                   .Build(),
                   "Get",
                   "/test_projectKey/import-sinks?offset=0.7475848",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/import-sinks?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-sinks",
               }
       };
        }
    }
}
