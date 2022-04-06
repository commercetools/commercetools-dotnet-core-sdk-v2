using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests.Client.RequestBuilders.OrderPatches
{
    public class ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyTest : RequestBuilderParentTests
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
                   .OrderPatches()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/order-patches/importSinkKey=test_importSinkKey",
               }
       };
        }
    }
}
