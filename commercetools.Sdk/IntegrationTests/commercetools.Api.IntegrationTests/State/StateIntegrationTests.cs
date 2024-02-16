using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.States;
using Xunit;
using static commercetools.Api.IntegrationTests.State.StateFixtures;

namespace commercetools.Api.IntegrationTests.State
{
    [Collection("Integration Tests")]
    public class StateIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public StateIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateState()
        {
            var key = $"CreateState-{TestingUtility.RandomString()}";
            await WithState(
                _client, stateDraft => DefaultStateDraftWithKey(stateDraft, key),
                state => { Assert.Equal(key, state.Key); }
            );
        }

        [Fact]
        public async Task GetStateById()
        {
            var key = $"GetStateById-{TestingUtility.RandomString()}";
            await WithState(
                _client,
                stateDraft => DefaultStateDraftWithKey(stateDraft, key),
                async state =>
                {
                    Assert.NotNull(state);
                    var retrievedState = await _client
                        .States()
                        .WithId(state.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedState);
                    Assert.Equal(key, retrievedState.Key);
                }
            );
        }

        [Fact]
        public async Task QueryState()
        {
            var key = $"QueryState-{TestingUtility.RandomString()}";
            await WithState(
                _client,
                stateDraft => DefaultStateDraftWithKey(stateDraft, key),
                async state =>
                {
                    Assert.NotNull(state);
                    var returnedSet = await _client
                        .States()
                        .WithKey(key)
                        .Get()
                        .ExecuteAsync();

                    Assert.Equal(key, returnedSet.Key);
                });
        }

        [Fact]
        public async Task UpdateStateByIdChangeDescription()
        {
            await WithUpdateableState(
                _client,
                async state =>
                {
                    Assert.NotNull(state);
                    var desc = $"Test-Desc-{TestingUtility.RandomString()}";
                    var action = new StateSetDescriptionAction()
                    {
                        Action = "setDescription",
                        Description = new LocalizedString() { { "en", desc } }
                    };

                    var update = new StateUpdate()
                    {
                        Version = state.Version,
                        Actions = new List<IStateUpdateAction>() { action }
                    };

                    var updatedState = await _client
                        .States()
                        .WithId(state.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedState.Description, new LocalizedString() { { "en", desc } });
                    return updatedState;
                }
            );
        }
    }
}