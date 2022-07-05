using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeCustomLineItemMoneyAction : ICartChangeCustomLineItemMoneyAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IMoney Money { get; set; }
        public CartChangeCustomLineItemMoneyAction()
        {
            this.Action = "changeCustomLineItemMoney";
        }
    }
}
