

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemInventoryModeAction : ICartSetLineItemInventoryModeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IInventoryMode InventoryMode { get; set; }
        public CartSetLineItemInventoryModeAction()
        {
            this.Action = "setLineItemInventoryMode";
        }
    }
}
