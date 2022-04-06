using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.ImportSummaries
{
    public class ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyTest : RequestBuilderParentTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void WithMethods(HttpRequestMessage request, string httpMethod, string uri)
        {
            Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
            Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
        }

        [Obsolete]
        public static IEnumerable<object[]> GetData()
        {
            return new List<object[]> {
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSummaries()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-summaries/importSinkKey=test_importSinkKey",
               }
       };
        }
    }
}
