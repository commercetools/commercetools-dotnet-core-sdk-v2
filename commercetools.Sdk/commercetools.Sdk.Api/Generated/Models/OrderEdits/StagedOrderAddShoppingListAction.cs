using commercetools.Api.Models.Channels;
using commercetools.Api.Models.ShoppingLists;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddShoppingListAction : IStagedOrderAddShoppingListAction
    {
        public string Action { get; set; }

        public IShoppingListResourceIdentifier ShoppingList { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public StagedOrderAddShoppingListAction()
        {
            this.Action = "addShoppingList";
        }
    }
}
