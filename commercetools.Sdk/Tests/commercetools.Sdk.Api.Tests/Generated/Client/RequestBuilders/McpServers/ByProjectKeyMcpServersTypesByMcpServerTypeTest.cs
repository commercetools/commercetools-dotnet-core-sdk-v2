using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.McpServers
{
    public class ByProjectKeyMcpServersTypesByMcpServerTypeTest : RequestBuilderParentTests
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
                   .McpServers()
                   .Types()
                   .WithMcpServerType("test_mcpServerType")
                   .Get()
                   .WithMajorVersion("majorVersion")
                   .Build(),
                   "Get",
                   "/test_projectKey/mcp-servers/types/test_mcpServerType?majorVersion=majorVersion",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .McpServers()
                   .Types()
                   .WithMcpServerType("test_mcpServerType")
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/mcp-servers/types/test_mcpServerType",
               }
       };
        }
    }
}
