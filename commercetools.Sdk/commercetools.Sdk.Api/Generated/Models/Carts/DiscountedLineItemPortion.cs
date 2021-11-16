using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public ICartDiscountReference Discount { get; set;}
        
        public ITypedMoney DiscountedAmount { get; set;}
    }
}
