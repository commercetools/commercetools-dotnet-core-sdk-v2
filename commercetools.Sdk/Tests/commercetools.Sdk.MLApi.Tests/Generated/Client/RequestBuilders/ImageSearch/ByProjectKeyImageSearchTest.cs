using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.MLApi.Tests.Client.RequestBuilders.ImageSearch
{
    public class ByProjectKeyImageSearchTest : RequestBuilderParentTests
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
                   .ImageSearch()
                   .Post(null)
                   .WithLimit(7)
                   .Build(),
                   "Post",
                   "/test_projectKey/image-search?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ImageSearch()
                   .Post(null)
                   .WithOffset(3)
                   .Build(),
                   "Post",
                   "/test_projectKey/image-search?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ImageSearch()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/image-search",
               }
       };
        }
    }
}
