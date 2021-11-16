using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.MLApi.Tests.Client.RequestBuilders.Recommendations
{
    public class ByProjectKeyRecommendationsGeneralCategoriesTest:RequestBuilderParentTests 
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
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .WithProductImageUrl("productImageUrl")
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories?productImageUrl=productImageUrl",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .WithProductName("productName")
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories?productName=productName",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories?limit=7",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories?offset=3",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .WithConfidenceMin(0.7340351)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories?confidenceMin=0.7340351",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .WithConfidenceMax(0.30089796)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories?confidenceMax=0.30089796",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .GeneralCategories()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/general-categories",
               }
       };
    }
   }
}
