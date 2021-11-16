using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountSetDescriptionAction : IProductDiscountSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        public ProductDiscountSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
