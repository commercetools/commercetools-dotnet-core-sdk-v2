using System;
using System.Collections.Generic;
using System.Net.Http;
using commercetools.ImportApi.Models.Common;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.Orders
{
    public class ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsTest : RequestBuilderParentTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void WithMethods(HttpRequestMessage request, string httpMethod, string uri)
        {
            Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
            Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
        }

        [Obsolete]
        public static IEnumerable<object[]> GetData()
        {
            return new List<object[]> {
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithLimit(0.26748633)
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations?limit=0.26748633",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithOffset(0.7475848)
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations?offset=0.7475848",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithResourceKey("resourceKey")
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations?resourceKey=resourceKey",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithState(IProcessingState.FindEnum("state"))
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations?state=state",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithDebug(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations?debug=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey/import-operations",
               }
       };
        }
    }
}
