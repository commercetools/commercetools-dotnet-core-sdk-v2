using commercetools.Sdk.Api.Models.DiscountCodes;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartRemoveDiscountCodeAction : ICartRemoveDiscountCodeAction
    {
        public string Action { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }
        public CartRemoveDiscountCodeAction()
        {
            this.Action = "removeDiscountCode";
        }
    }
}
