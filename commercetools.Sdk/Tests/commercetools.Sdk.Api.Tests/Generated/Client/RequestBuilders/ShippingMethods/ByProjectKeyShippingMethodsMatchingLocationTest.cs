using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ShippingMethods
{
    public class ByProjectKeyShippingMethodsMatchingLocationTest : RequestBuilderParentTests
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
                   .MatchingLocation()
                   .Get()
                   .WithCountry("country")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-location?country=country",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingLocation()
                   .Get()
                   .WithState("state")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-location?state=state",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingLocation()
                   .Get()
                   .WithCurrency("currency")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-location?currency=currency",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingLocation()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-location?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingLocation()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-location?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingLocation()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-location",
               }
       };
        }
    }
}
