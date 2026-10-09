using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.CheckoutApi.Tests;
using commercetools.Sdk.CheckoutApi.Models;
using commercetools.Sdk.CheckoutApi.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Tests.Client.RequestBuilders.RecurringPayment
{
   public class ByProjectKeyRecurringPaymentJobsByIdTest:RequestBuilderParentTests 
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
                   .RecurringPaymentJobs()
                   .WithId("test_id")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs/test_id",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .WithId("test_id")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/recurring-payment-jobs/test_id?version=2",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .WithId("test_id")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/recurring-payment-jobs/test_id",
               }
       };
    }
   }
}
