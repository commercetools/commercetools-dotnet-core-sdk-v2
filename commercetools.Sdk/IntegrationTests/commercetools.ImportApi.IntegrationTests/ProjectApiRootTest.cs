using System.Collections.Generic;
using System.Linq;
using commercetools.Sdk.ImportApi.Client;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Projects;
using Xunit;

namespace commercetools.Api.IntegrationTests
{
    public class ProjectApiRootTest
    {

        private List<string> ignoreMethods = new List<string>()
        {
        };

        [Fact]
        public void allSubResourcesSupported()
        {
            var projectApiRootMethods = typeof(ProjectApiRoot).GetMethods()
                .Where(info => info.IsPublic)
                .Select(info => info.Name)
                .Distinct()
                .ToList();

            var resourceMethods = typeof(ByProjectKeyRequestBuilder).GetMethods()
                .Where(info => info.IsPublic)
                .Select(info => info.Name)
                .Where(name => !ignoreMethods.Contains(name))
                .Where(name => !projectApiRootMethods.Contains(name))
                .ToList();

            Assert.Empty(resourceMethods);
        }
    }
}