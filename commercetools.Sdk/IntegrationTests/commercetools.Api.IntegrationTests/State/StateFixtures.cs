using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.States;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.State
{
    public class StateFixtures
    {
        #region DraftBuilds

        public static StateDraft DefaultStateDraft(StateDraft stateDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            stateDraft.Key = $"Test-Key-{randomInt}";
            stateDraft.Type = IStateTypeEnum.LineItemState;
            stateDraft.Roles = new List<IStateRoleEnum>()
            {
                IStateRoleEnum.Return
            };

            return stateDraft;
        }

        #endregion

        public static StateDraft DefaultStateDraftWithKey(StateDraft draft, string key)
        {
            var stateDraft = DefaultStateDraft(draft);
            stateDraft.Key = key;

            return stateDraft;
        }

        public static async Task<IState> CreateState(ProjectApiRoot client,
            StateDraft stateDraft)
        {
            try
            {
                return await client
                    .States()
                    .Post(stateDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteState(ProjectApiRoot client, IState state)
        {
            try
            {
                await client
                    .States()
                    .WithId(state.Id)
                    .Delete()
                    .WithVersion(state.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithState(ProjectApiRoot client,
            Func<StateDraft, StateDraft> draftAction,
            Action<IState> func)
        {
            await With(client, new StateDraft(), draftAction, func, CreateState,
                DeleteState);
        }

        public static async Task WithState(ProjectApiRoot client,
            Func<StateDraft, StateDraft> draftAction,
            Func<IState, Task> func)
        {
            await WithAsync(client, new StateDraft(), draftAction, func, CreateState,
                DeleteState);
        }

        public static async Task WithUpdateableState(ProjectApiRoot client,
            Func<IState, Task<IState>> func)
        {
            await WithUpdateableAsync(client, new StateDraft(), DefaultStateDraft, func,
                CreateState,
                DeleteState);
        }

        #endregion
    }
}