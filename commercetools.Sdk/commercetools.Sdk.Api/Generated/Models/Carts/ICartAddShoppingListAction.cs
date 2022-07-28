using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddShoppingListAction))]
    public partial interface ICartAddShoppingListAction : ICartUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

    }
}
