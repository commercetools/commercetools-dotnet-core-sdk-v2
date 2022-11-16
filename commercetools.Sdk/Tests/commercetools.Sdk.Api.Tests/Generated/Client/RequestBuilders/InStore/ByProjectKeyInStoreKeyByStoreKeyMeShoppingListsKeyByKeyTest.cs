using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.InStore
{
    public class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyTest : RequestBuilderParentTests
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
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Delete()
                   .WithExpand("expand")
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Delete()
                   .WithDataErasure(true)
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key?dataErasure=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Delete()
                   .WithVersion(2)
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key?version=2",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .InStoreKeyWithStoreKeyValue("test_storeKey")
                   .Me()
                   .ShoppingLists()
                   .WithKey("test_key")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/in-store/key=test_storeKey/me/shopping-lists/key=test_key",
               }
       };
        }
    }
}
