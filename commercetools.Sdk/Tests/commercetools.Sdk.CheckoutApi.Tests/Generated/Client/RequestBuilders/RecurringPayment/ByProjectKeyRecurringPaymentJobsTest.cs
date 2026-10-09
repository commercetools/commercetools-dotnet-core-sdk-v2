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
   public class ByProjectKeyRecurringPaymentJobsTest:RequestBuilderParentTests 
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
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs?sort=sort",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs?limit=7",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs?offset=3",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs?withTotal=true",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .Get()
                   .WithStatusState("status.state")
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs?status.state=status.state",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/recurring-payment-jobs",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurringPaymentJobs()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/recurring-payment-jobs",
               }
       };
    }
   }
}
