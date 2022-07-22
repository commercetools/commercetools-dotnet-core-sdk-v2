namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeCustomLineItemPriceModeAction : ICartChangeCustomLineItemPriceModeAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public ICustomLineItemPriceMode Mode { get; set; }
        public CartChangeCustomLineItemPriceModeAction()
        {
            this.Action = "changeCustomLineItemPriceMode";
        }
    }
}
