using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.ShippingMethods
{
    public class ByProjectKeyShippingMethodsMatchingCartLocationTest : RequestBuilderParentTests
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
                   .MatchingCartLocation()
                   .Get()
                   .WithCountry("country")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart-location?country=country",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingCartLocation()
                   .Get()
                   .WithState("state")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart-location?state=state",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingCartLocation()
                   .Get()
                   .WithCartId("cartId")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart-location?cartId=cartId",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingCartLocation()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart-location?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingCartLocation()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart-location",
               }
       };
        }
    }
}
