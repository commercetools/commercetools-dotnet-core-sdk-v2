using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.InStore
{
    public class ByProjectKeyInStoreKeyByStoreKeyQuotesTest : RequestBuilderParentTests
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
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/quotes",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/in-store/key=test_storeKey/quotes",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/quotes?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Quotes()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/quotes",
               }
       };
        }
    }
}
