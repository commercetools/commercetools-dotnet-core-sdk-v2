using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.Variants
{
    public class ByProjectKeyVariantsByIDImagesTest : RequestBuilderParentTests
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
                   .Variants()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .WithFilename("filename")
                   .Build(),
                   "Post",
                   "/test_projectKey/variants/test_ID/images?filename=filename",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .WithStaged(true)
                   .Build(),
                   "Post",
                   "/test_projectKey/variants/test_ID/images?staged=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .Variants()
                   .WithId("test_ID")
                   .Images()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/variants/test_ID/images",
               }
       };
        }
    }
}
