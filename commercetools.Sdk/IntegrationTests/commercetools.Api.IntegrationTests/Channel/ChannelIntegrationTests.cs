using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using Xunit;
using static commercetools.Api.IntegrationTests.Channel.ChannelFixtures;

namespace commercetools.Api.IntegrationTests.Channel
{
    [Collection("Integration Tests")]
    public class ChannelIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public ChannelIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateChannel()
        {
            var key = $"CreateChannel-{TestingUtility.RandomString()}";
            await WithChannel(
                _client,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                channel => { Assert.Equal(key, channel.Key); }
            );
        }

        [Fact]
        public async Task GetChannelById()
        {
            var key = $"GetChannelById-{TestingUtility.RandomString()}";
            await WithChannel(
                _client,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                async channel =>
                {
                    Assert.NotNull(channel);
                    var retrievedChannel = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Channels()
                        .WithId(channel.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedChannel);
                    Assert.Equal(key, retrievedChannel.Key);
                }
            );
        }

        [Fact]
        public async Task QueryChannels()
        {
            var key = $"QueryChannels-{TestingUtility.RandomString()}";
            await WithChannel(
                _client,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                async channel =>
                {
                    Assert.NotNull(channel);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Channels()
                        .Get()
                        .WithQuery(q => q.Key().Is(channel.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateChannelByIdSetGeoLocation()
        {
            await WithUpdateableChannel(
                _client,
                async channel =>
                {
                    Assert.NotNull(channel);
                    var location = new GeoJsonPoint()
                    {
                        Type = "Point",
                        Coordinates = new List<decimal>() { 0, 0 }
                    };

                    var action = new ChannelSetGeoLocationAction()
                    {
                        Action = "setGeoLocation",
                        GeoLocation = location
                    };

                    var update = new ChannelUpdate()
                    {
                        Version = channel.Version,
                        Actions = new List<IChannelUpdateAction>() { action }
                    };

                    var updatedChannel = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Channels()
                        .WithId(channel.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedChannel.GeoLocation.ToString(), location.ToString());
                    return updatedChannel;
                }
            );
        }
    }
}