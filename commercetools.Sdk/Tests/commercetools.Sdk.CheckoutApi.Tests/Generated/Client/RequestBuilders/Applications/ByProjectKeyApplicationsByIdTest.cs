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
   public class ByProjectKeyApplicationsByIdTest:RequestBuilderParentTests 
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
                   .WithId("test_id")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/applications/test_id",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .WithId("test_id")
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/applications/test_id",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .WithId("test_id")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/applications/test_id",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Applications()
                   .WithId("test_id")
                   .Delete(null)
                   .Build(),
                   "Delete",
                   "/test_projectKey/applications/test_id",
               }
       };
    }
   }
}
