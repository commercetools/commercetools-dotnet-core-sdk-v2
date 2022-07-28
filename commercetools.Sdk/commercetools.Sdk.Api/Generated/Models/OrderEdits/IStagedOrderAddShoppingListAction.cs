using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddShoppingListAction))]
    public partial interface IStagedOrderAddShoppingListAction : IStagedOrderUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

    }
}
