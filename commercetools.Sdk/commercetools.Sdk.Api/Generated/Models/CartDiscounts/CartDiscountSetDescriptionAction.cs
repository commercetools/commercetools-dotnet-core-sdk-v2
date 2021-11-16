using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetDescriptionAction : ICartDiscountSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        public CartDiscountSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
