using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
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
