using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using Xunit;
using static commercetools.Api.IntegrationTests.Extension.ExtensionFixtures;

namespace commercetools.Api.IntegrationTests.Extension
{
    [Collection("Integration Tests")]
    public class ExtensionIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public ExtensionIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateExtension()
        {
            var key = $"CreateExtension-{TestingUtility.RandomString()}";
            await WithExtension(
                _client,
                extensionDraft => DefaultExtensionDraftWithKey(extensionDraft, key),
                extension => { Assert.Equal(key, extension.Key); }
            );
        }

        [Fact]
        public async Task GetExtensionById()
        {
            var key = $"GetExtensionById-{TestingUtility.RandomString()}";
            await WithExtension(
                _client,
                extensionDraft => DefaultExtensionDraftWithKey(extensionDraft, key),
                async extension =>
                {
                    Assert.NotNull(extension);
                    var retrievedExtension = await _client
                        .Extensions()
                        .WithId(extension.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedExtension);
                    Assert.Equal(key, retrievedExtension.Key);
                }
            );
        }

        // [Fact]
        // public async Task QueryExtensions()
        // {
        //     var key = $"QueryExtensions-{TestingUtility.RandomString()}";
        //     await WithExtension(
        //         _client,
        //         extensionDraft => DefaultExtensionDraftWithKey(extensionDraft, key),
        //         async extension =>
        //         {
        //             Assert.NotNull(extension);
        //             var returnedSet = await _client
        //                 .WithApi()
        //                 .WithProjectKey(_projectKey)
        //                 .Extensions()
        //                 .Get()
        //                 // .WithQuery(q => q.Key().Is(extension.Key))
        //                 .ExecuteAsync();
        //
        //             Assert.Single(returnedSet.Results);
        //             Assert.Equal(key, returnedSet.Results[0].Key);
        //         });
        // }

        // [Fact]
        // public async Task UpdateExtensionByIdChangeFirstName()
        // {
        //     await WithUpdateableExtension(
        //         _client,
        //         async extension =>
        //         {
        //             Assert.NotNull(extension);
        //             var name = $"{TestingUtility.RandomString()}";
        //             var action = new ExtensionSetFirstNameAction()
        //             {
        //                 Action = "setFirstName",
        //                 FirstName = name
        //             };
        //
        //             var update = new ExtensionUpdate()
        //             {
        //                 Version = extension.Version,
        //                 Actions = new List<IExtensionUpdateAction>() { action }
        //             };
        //
        //             var updatedExtension = await _client
        //                 .WithApi()
        //                 .WithProjectKey(_projectKey)
        //                 .Extensions()
        //                 .WithId(extension.Id)
        //                 .Post(update)
        //                 .ExecuteAsync();
        //
        //             Assert.Equal(updatedExtension.FirstName, name);
        //             return updatedExtension;
        //         }
        //     );
        // }
    }
}