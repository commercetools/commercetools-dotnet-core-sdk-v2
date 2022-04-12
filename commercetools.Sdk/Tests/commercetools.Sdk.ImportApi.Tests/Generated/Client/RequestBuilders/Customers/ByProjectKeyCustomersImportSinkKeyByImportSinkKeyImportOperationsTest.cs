using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.Customers
{
    public class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsTest : RequestBuilderParentTests
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
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithLimit((decimal)0.26748633)
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations?limit=0.26748633",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithOffset((decimal)0.7475848)
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations?offset=0.7475848",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithResourceKey("resourceKey")
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations?resourceKey=resourceKey",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithState(commercetools.Sdk.ImportApi.Models.Common.IProcessingState.FindEnum("state"))
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations?state=state",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .WithDebug(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations?debug=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Customers()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .ImportOperations()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations",
               }
       };
        }
    }
}
