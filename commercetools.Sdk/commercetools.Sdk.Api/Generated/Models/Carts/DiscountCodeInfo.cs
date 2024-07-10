using commercetools.Sdk.Api.Models.DiscountCodes;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
