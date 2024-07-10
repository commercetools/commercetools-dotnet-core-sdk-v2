namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddDiscountCodeAction : ICartAddDiscountCodeAction
    {
        public string Action { get; set; }

        public string Code { get; set; }
        public CartAddDiscountCodeAction()
        {
            this.Action = "addDiscountCode";
        }
    }
}
