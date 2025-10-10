using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.CheckoutApi.Tests;
using commercetools.Sdk.CheckoutApi.Models;
using commercetools.Sdk.CheckoutApi.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Tests.Client.RequestBuilders.PaymentIntegrations
{
   public class ByProjectKeyPaymentIntegrationsKeyByKeyTest:RequestBuilderParentTests 
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
                   .PaymentIntegrations()
                   .WithKey("test_key")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/payment-integrations/key=test_key",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .PaymentIntegrations()
                   .WithKey("test_key")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/payment-integrations/key=test_key",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .PaymentIntegrations()
                   .WithKey("test_key")
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/payment-integrations/key=test_key",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .PaymentIntegrations()
                   .WithKey("test_key")
                   .Delete(null)
                   .Build(),
                   "Delete",
                   "/test_projectKey/payment-integrations/key=test_key",
               }
       };
    }
   }
}
