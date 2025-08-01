using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.RecurrencePolicies
{
    public class ByProjectKeyRecurrencePoliciesKeyByKeyTest : RequestBuilderParentTests
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
                   .RecurrencePolicies()
                   .WithKey("test_key")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/recurrence-policies/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurrencePolicies()
                   .WithKey("test_key")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/recurrence-policies/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurrencePolicies()
                   .WithKey("test_key")
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/recurrence-policies/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurrencePolicies()
                   .WithKey("test_key")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/recurrence-policies/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .RecurrencePolicies()
                   .WithKey("test_key")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/recurrence-policies/key=test_key",
               }
       };
        }
    }
}
