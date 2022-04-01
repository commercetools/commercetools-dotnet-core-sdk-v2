using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.Orders
{
    public class ByProjectKeyOrdersOrderNumberByOrderNumberTest : RequestBuilderParentTests
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
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/order-number=test_orderNumber?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/order-number=test_orderNumber",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/orders/order-number=test_orderNumber?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/orders/order-number=test_orderNumber",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Delete()
                   .WithDataErasure(true)
                   .Build(),
                   "Delete",
                   "/test_projectKey/orders/order-number=test_orderNumber?dataErasure=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/orders/order-number=test_orderNumber?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/orders/order-number=test_orderNumber?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Orders()
                   .WithOrderNumber("test_orderNumber")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/orders/order-number=test_orderNumber",
               }
       };
        }
    }
}
