using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Extensions;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.Extension
{
    public class ExtensionFixtures
    {
        #region DraftBuilds

        public static ExtensionDraft DefaultExtensionDraft(ExtensionDraft extensionDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            var action = new ExtensionAction() { };

            extensionDraft.Destination = new HttpDestination()
            {
                Type = "HTTP",
                Url = "https://www.commercetools.com"
            };
            extensionDraft.Triggers = new List<IExtensionTrigger>()
            {
                new ExtensionTrigger()
                {
                    ResourceTypeId = IExtensionResourceTypeId.Cart,
                    Actions = new List<IExtensionAction>()
                    {
                       IExtensionAction.Create
                    }
                }
            };

            return extensionDraft;
        }

        #endregion

        public static ExtensionDraft DefaultExtensionDraftWithKey(ExtensionDraft draft, string key)
        {
            var extensionDraft = DefaultExtensionDraft(draft);
            extensionDraft.Key = key;

            return extensionDraft;
        }

        public static async Task<IExtension> CreateExtension(ProjectApiRoot client, ExtensionDraft extensionDraft)
        {
            try
            {
                return await client
                    .Extensions()
                    .Post(extensionDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteExtension(ProjectApiRoot client, IExtension extension)
        {
            try
            {
                await client
                    .Extensions()
                    .WithKey(extension.Key)
                    .Delete()
                    .WithVersion(extension.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithExtension(ProjectApiRoot client, Func<ExtensionDraft, ExtensionDraft> draftAction,
            Action<IExtension> func)
        {
            await With(client, new ExtensionDraft(), draftAction, func, CreateExtension, DeleteExtension);
        }

        public static async Task WithExtension(ProjectApiRoot client, Func<ExtensionDraft, ExtensionDraft> draftAction,
            Func<IExtension, Task> func)
        {
            await WithAsync(client, new ExtensionDraft(), draftAction, func, CreateExtension, DeleteExtension);
        }

        public static async Task WithExtension(ProjectApiRoot client, Func<IExtension, Task> func)
        {
            await WithAsync(client, new ExtensionDraft(), DefaultExtensionDraft, func, CreateExtension,
                DeleteExtension);
        }

        public static async Task WithUpdateableExtension(ProjectApiRoot client, Func<IExtension, Task<IExtension>> func)
        {
            await WithUpdateableAsync(client, new ExtensionDraft(), DefaultExtensionDraft, func, CreateExtension,
                DeleteExtension);
        }

        #endregion
    }
}