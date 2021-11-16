using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.DiscountedLineItemPortion))]
    public partial interface IDiscountedLineItemPortion 
    {
        ICartDiscountReference Discount { get; set;}
        
        ITypedMoney DiscountedAmount { get; set;}
    }
}
