using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Api.Models;
using commercetools.Api.Models.Common;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.ShippingMethods
{
   public class ByProjectKeyShippingMethodsMatchingCartTest:RequestBuilderParentTests 
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
                   .ShippingMethods()
                   .MatchingCart()
                   .Get()
                   .WithCartId("cartId")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart?cartId=cartId",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingCart()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart?expand=expand",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingCart()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-cart",
               }
       };
    }
   }
}
