using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Zones;
using Xunit;
using static commercetools.Api.IntegrationTests.Zone.ZoneFixtures;

namespace commercetools.Api.IntegrationTests.Zone
{
    [Collection("Integration Tests")]
    public class ZoneIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public ZoneIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateZone()
        {
            var key = $"CreateZone-{TestingUtility.RandomString()}";
            await WithZone(
                _client, zoneDraft => DefaultZoneDraftWithKey(zoneDraft, key),
                zone => { Assert.Equal(key, zone.Key); }
            );
        }

        [Fact]
        public async Task GetZoneById()
        {
            var key = $"GetZoneById-{TestingUtility.RandomString()}";
            await WithZone(
                _client,
                zoneDraft => DefaultZoneDraftWithKey(zoneDraft, key),
                async zone =>
                {
                    Assert.NotNull(zone);
                    var retrievedZone = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Zones()
                        .WithId(zone.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedZone);
                    Assert.Equal(key, retrievedZone.Key);
                }
            );
        }

        [Fact]
        public async Task QueryZone()
        {
            var key = $"QueryZone-{TestingUtility.RandomString()}";
            await WithZone(
                _client,
                zoneDraft => DefaultZoneDraftWithKey(zoneDraft, key),
                async zone =>
                {
                    Assert.NotNull(zone);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Zones()
                        .Get()
                        .WithQuery(q => q.Key().Is(zone.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateZoneByIdChangeDescription()
        {
            await WithUpdateableZone(
                _client,
                async zone =>
                {
                    Assert.NotNull(zone);
                    var name = $"Test-Desc-{TestingUtility.RandomString()}";
                    var action = new ZoneSetDescriptionAction()
                    {
                        Action = "setDescription",
                        Description = name,
                    };

                    var update = new ZoneUpdate()
                    {
                        Version = zone.Version,
                        Actions = new List<IZoneUpdateAction>() { action }
                    };

                    var updatedZone = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Zones()
                        .WithId(zone.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedZone.Description, name);
                    return updatedZone;
                }
            );
        }
    }
}