using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Types;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Api.IntegrationTests.Type
{
    public class TypeFixtures
    {
        #region DraftBuilds

        public static TypeDraft DefaultTypeDraft(TypeDraft typeDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            typeDraft.Key = $"Test-Key-{randomInt}";
            typeDraft.Name = new LocalizedString() { { "de", $"Test-Name-{randomStr}" } };
            typeDraft.ResourceTypeIds = new List<IResourceTypeId>()
            {
                IResourceTypeId.Asset,
                IResourceTypeId.Category,
                IResourceTypeId.Order,
                IResourceTypeId.PaymentInterfaceInteraction,
                IResourceTypeId.Payment,
                IResourceTypeId.CartDiscount
            };

            return typeDraft;
        }

        #endregion

        public static TypeDraft DefaultTypeDraftWithKey(TypeDraft draft, string key)
        {
            var typeDraft = DefaultTypeDraft(draft);
            typeDraft.Key = key;

            return typeDraft;
        }

        public static async Task<IType> CreateType(ProjectApiRoot client,
            TypeDraft typeDraft)
        {
            try
            {
                return await client
                    .Types()
                    .Post(typeDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteType(ProjectApiRoot client, IType type)
        {
            try
            {
                await client
                    .Types()
                    .WithId(type.Id)
                    .Delete()
                    .WithVersion(type.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithType(ProjectApiRoot client,
            Func<TypeDraft, TypeDraft> draftAction,
            Action<IType> func)
        {
            await With(client, new TypeDraft(), draftAction, func, CreateType,
                DeleteType);
        }

        public static async Task WithType(ProjectApiRoot client,
            Func<TypeDraft, TypeDraft> draftAction,
            Func<IType, Task> func)
        {
            await WithAsync(client, new TypeDraft(), draftAction, func, CreateType,
                DeleteType);
        }

        public static async Task WithUpdateableType(ProjectApiRoot client,
            Func<IType, Task<IType>> func)
        {
            await WithUpdateableAsync(client, new TypeDraft(), DefaultTypeDraft, func,
                CreateType,
                DeleteType);
        }

        #endregion
    }
}