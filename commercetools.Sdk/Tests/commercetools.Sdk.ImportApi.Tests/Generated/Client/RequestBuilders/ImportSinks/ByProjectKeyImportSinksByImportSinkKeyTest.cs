using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.ImportSinks
{
    public class ByProjectKeyImportSinksByImportSinkKeyTest:RequestBuilderParentTests 
   { 
       [Theory]
       [MemberData(nameof(GetData))]
       public void WithMethods(HttpRequestMessage request, string httpMethod, string uri) {
           Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
           Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
       }

        [Obsolete]
        public static IEnumerable<object[]> GetData() {
       return new List<object[]> {
               new Object[] {           
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .WithImportSinkKeyValue("test_importSinkKey")
                   .Put(null)
                   .Build(),
                   "Put",
                   "/test_projectKey/import-sinks/test_importSinkKey",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .WithImportSinkKeyValue("test_importSinkKey")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/import-sinks/test_importSinkKey",
               },
               new Object[] {           
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ImportSinks()
                   .WithImportSinkKeyValue("test_importSinkKey")
                   .Delete()
                   .Build(),
                   "Delete",
                   "/test_projectKey/import-sinks/test_importSinkKey",
               }
       };
    }
   }
}
