using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.MLApi.Tests.Client.RequestBuilders.ImageSearch
{
    public class ByProjectKeyImageSearchConfigTest:RequestBuilderParentTests 
   { 
       [Theory]
       [MemberData(nameof(GetData))]
       public void WithMethods(HttpRequestMessage request, string httpMethod, string uri) {
           Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
           Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
       }

       public static IEnumerable<object[]> GetData() {
       return new List<object[]> {
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ImageSearch()
                   .Config()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/image-search/config",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ImageSearch()
                   .Config()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/image-search/config",
               }
       };
    }
   }
}
