using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.Products
{
    public class ByProjectKeyProductsByIDImagesTest:RequestBuilderParentTests 
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
                   .Products()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .WithFilename("filename")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/test_ID/images?filename=filename",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .WithVariant(7)
                   .Build(),
                   "Post",
                   "/test_projectKey/products/test_ID/images?variant=7",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .WithSku("sku")
                   .Build(),
                   "Post",
                   "/test_projectKey/products/test_ID/images?sku=sku",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .WithStaged(true)
                   .Build(),
                   "Post",
                   "/test_projectKey/products/test_ID/images?staged=true",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Products()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/products/test_ID/images",
               }
       };
    }
   }
}
