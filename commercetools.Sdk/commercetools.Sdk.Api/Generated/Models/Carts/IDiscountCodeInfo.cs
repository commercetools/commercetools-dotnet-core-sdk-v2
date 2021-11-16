using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.DiscountCodeInfo))]
    public partial interface IDiscountCodeInfo 
    {
        IDiscountCodeReference DiscountCode { get; set;}
        
        IDiscountCodeState State { get; set;}
    }
}
