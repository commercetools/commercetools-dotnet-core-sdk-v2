using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.ShippingMethods
{
    public class ByProjectKeyShippingMethodsMatchingOrdereditTest:RequestBuilderParentTests 
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
                   .MatchingOrderedit()
                   .Get()
                   .WithOrderEditId("orderEditId")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-orderedit?orderEditId=orderEditId",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingOrderedit()
                   .Get()
                   .WithCountry("country")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-orderedit?country=country",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingOrderedit()
                   .Get()
                   .WithState("state")
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-orderedit?state=state",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .ShippingMethods()
                   .MatchingOrderedit()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/shipping-methods/matching-orderedit",
               }
       };
    }
   }
}
