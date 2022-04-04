namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetKeyAction : ICartDiscountSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public CartDiscountSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
