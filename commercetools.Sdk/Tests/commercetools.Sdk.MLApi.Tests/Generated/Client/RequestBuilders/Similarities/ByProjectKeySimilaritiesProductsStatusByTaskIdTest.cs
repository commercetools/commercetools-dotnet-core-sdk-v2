using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.MLApi.Tests.Client.RequestBuilders.Similarities
{
    public class ByProjectKeySimilaritiesProductsStatusByTaskIdTest : RequestBuilderParentTests
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
                   .WithProjectKey("test_projectKey")
                   .Similarities()
                   .Products()
                   .Status()
                   .WithTaskId("test_taskId")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/similarities/products/status/test_taskId",
               }
       };
        }
    }
}
