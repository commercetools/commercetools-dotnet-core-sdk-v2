using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Zones;
using Xunit;
using static commercetools.Api.IntegrationTests.Zone.ZoneFixtures;

namespace commercetools.Api.IntegrationTests.Zone
{
    [Collection("Integration Tests")]
    public class ZoneIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public ZoneIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
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