using commercetools.Api.Models.Channels;
using commercetools.Api.Models.ShoppingLists;


namespace commercetools.Api.Models.Carts
{
    public partial class CartAddShoppingListAction : ICartAddShoppingListAction
    {
        public string Action { get; set;}
        
        public IShoppingListResourceIdentifier ShoppingList { get; set;}
        
        public IChannelResourceIdentifier SupplyChannel { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        public CartAddShoppingListAction()
        { 
           this.Action = "addShoppingList";
        }
    }
}
