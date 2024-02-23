using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.IntegrationTests.Services
{
    public class ShoppingListServices
    {
        public const string ShoppingListKey = "ShoppingList_Me_Key123";

        public async Task<IShoppingList> GetShoppingListByKey(IClient adminClient, string key)
        {
            try
            {
                var shoppingList = await adminClient.WithApi(GenericFixture.DefaultProjectKey)
                    .ShoppingLists()
                    .WithKey(key)
                    .Get()
                    .ExecuteAsync();
                return shoppingList;
            }
            catch (NotFoundException)
            {
                // ignored
            }

            return null;
        }

        public async Task<IShoppingList> CreateShoppingList(IClient adminClient, IShoppingListDraft shoppingListDraft)
        {
            var shoppingList = await adminClient.WithApi(GenericFixture.DefaultProjectKey)
                .ShoppingLists()
                .Post(shoppingListDraft)
                .ExecuteAsync();
            return shoppingList;
        }

        public IShoppingListDraft CreateShoppingListDraft(ICustomerResourceIdentifier customerResourceIdentifier)
        {
            return new ShoppingListDraft()
            {
                Key = ShoppingListKey,
                Customer = customerResourceIdentifier,
                Name = new LocalizedString
               {
                   {"en", ShoppingListKey}
               }
            };
        }
    }
}