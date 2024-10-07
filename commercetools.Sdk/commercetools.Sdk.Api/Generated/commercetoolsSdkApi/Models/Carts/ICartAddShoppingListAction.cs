using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddShoppingListAction))]
    public partial interface ICartAddShoppingListAction : ICartUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

    }
}
