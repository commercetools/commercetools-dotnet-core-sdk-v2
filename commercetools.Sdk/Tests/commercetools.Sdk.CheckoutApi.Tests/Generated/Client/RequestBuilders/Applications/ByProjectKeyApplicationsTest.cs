using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.CheckoutApi.Tests;
using commercetools.Sdk.CheckoutApi.Models;
using commercetools.Sdk.CheckoutApi.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Tests.Client.RequestBuilders.Applications
{
   public class ByProjectKeyApplicationsTest:RequestBuilderParentTests 
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
                   .Applications()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/applications?sort=sort",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/applications?limit=7",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/applications?offset=3",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/applications?withTotal=true",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/applications",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/applications",
               }
       };
    }
   }
}
