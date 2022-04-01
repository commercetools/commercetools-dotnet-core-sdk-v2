using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountCodeInfo))]
    public partial interface IDiscountCodeInfo
    {
        IDiscountCodeReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }
    }
}
