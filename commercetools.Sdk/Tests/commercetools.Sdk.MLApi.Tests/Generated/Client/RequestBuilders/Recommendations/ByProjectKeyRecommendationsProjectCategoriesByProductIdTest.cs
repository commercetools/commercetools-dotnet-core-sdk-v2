using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Tests.Client.RequestBuilders.Recommendations
{
    public class ByProjectKeyRecommendationsProjectCategoriesByProductIdTest : RequestBuilderParentTests
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
                   .Recommendations()
                   .ProjectCategories()
                   .WithProductId("test_productId")
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/project-categories/test_productId?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .ProjectCategories()
                   .WithProductId("test_productId")
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/project-categories/test_productId?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .ProjectCategories()
                   .WithProductId("test_productId")
                   .Get()
                   .WithStaged(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/project-categories/test_productId?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .ProjectCategories()
                   .WithProductId("test_productId")
                   .Get()
                   .WithConfidenceMin((decimal)0.7340351)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/project-categories/test_productId?confidenceMin=0.7340351",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .ProjectCategories()
                   .WithProductId("test_productId")
                   .Get()
                   .WithConfidenceMax((decimal)0.30089796)
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/project-categories/test_productId?confidenceMax=0.30089796",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Recommendations()
                   .ProjectCategories()
                   .WithProductId("test_productId")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/recommendations/project-categories/test_productId",
               }
       };
        }
    }
}
