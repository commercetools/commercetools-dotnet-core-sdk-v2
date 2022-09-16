using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.MLApi.Tests.Client.RequestBuilders.MissingData
{
    public class ByProjectKeyMissingDataImagesStatusByTaskIdTest : RequestBuilderParentTests
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
                   .WithProjectKey("test_projectKey")
                   .MissingData()
                   .Images()
                   .Status()
                   .WithTaskId("test_taskId")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/missing-data/images/status/test_taskId",
               }
       };
        }
    }
}
