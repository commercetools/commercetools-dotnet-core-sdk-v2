using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.CustomObjects;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.CustomObject
{
    public class CustomObjectFixtures
    {
        #region DraftBuilds

        public static CustomObjectDraft DefaultCustomObjectDraft(CustomObjectDraft customObjectDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            customObjectDraft.Key = $"CustomObject-Key-{randomStr}";
            customObjectDraft.Container = $"container-{randomStr}";
            customObjectDraft.Value = 5;

            return customObjectDraft;
        }

        #endregion

        public static CustomObjectDraft DefaultCustomObjectDraftWithKey(CustomObjectDraft draft, string key)
        {
            var customObjectDraft = DefaultCustomObjectDraft(draft);
            customObjectDraft.Key = key;

            return customObjectDraft;
        }

        public static async Task<ICustomObject> CreateCustomObject(ProjectApiRoot client, CustomObjectDraft customObjectDraft)
        {
            try
            {
                return await client
                    .CustomObjects()
                    .Post(customObjectDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteCustomObject(ProjectApiRoot client, ICustomObject customObject)
        {
            try
            {
                await client
                    .CustomObjects()
                    .WithContainerAndKey(customObject.Container, customObject.Key)
                    .Delete()
                    .WithVersion(customObject.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithCustomObject(ProjectApiRoot client,
            Func<CustomObjectDraft, CustomObjectDraft> draftAction,
            Action<ICustomObject> func)
        {
            await With(client, new CustomObjectDraft(), draftAction, func, CreateCustomObject,
                DeleteCustomObject);
        }

        public static async Task WithCustomObject(ProjectApiRoot client,
            Func<CustomObjectDraft, CustomObjectDraft> draftAction,
            Func<ICustomObject, Task> func)
        {
            await WithAsync(client, new CustomObjectDraft(), draftAction, func, CreateCustomObject,
                DeleteCustomObject);
        }

        public static async Task WithUpdateableCustomObject(ProjectApiRoot client,
            Func<ICustomObject, Task<ICustomObject>> func)
        {
            await WithUpdateableAsync(client, new CustomObjectDraft(), DefaultCustomObjectDraft, func,
                CreateCustomObject,
                DeleteCustomObject);
        }

        #endregion
    }
}