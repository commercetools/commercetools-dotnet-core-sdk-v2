using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ShippingMethods
{
    public class ByProjectKeyShippingMethodsByIDTest : RequestBuilderParentTests
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
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/test_ID?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/test_ID",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/shipping-methods/test_ID?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/shipping-methods/test_ID",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/shipping-methods/test_ID?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/shipping-methods/test_ID?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .WithId("test_ID")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/shipping-methods/test_ID",
               }
       };
        }
    }
}
