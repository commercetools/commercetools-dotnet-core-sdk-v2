using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.Customers
{
    public class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdTest : RequestBuilderParentTests
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
                   .WithIdValue("test_id")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/customers/importSinkKey=test_importSinkKey/import-operations/test_id",
               }
       };
        }
    }
}
