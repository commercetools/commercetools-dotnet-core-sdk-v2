using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.ShoppingLists;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddShoppingListAction : ICartAddShoppingListAction
    {
        public string Action { get; set; }

        public IShoppingListResourceIdentifier ShoppingList { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public CartAddShoppingListAction()
        {
            this.Action = "addShoppingList";
        }
    }
}
