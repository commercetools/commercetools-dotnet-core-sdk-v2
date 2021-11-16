using commercetools.Api.Models.DiscountCodes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartRemoveDiscountCodeAction : ICartRemoveDiscountCodeAction
    {
        public string Action { get; set;}
        
        public IDiscountCodeReference DiscountCode { get; set;}
        public CartRemoveDiscountCodeAction()
        { 
           this.Action = "removeDiscountCode";
        }
    }
}
