using commercetools.Api.Models.DiscountCodes;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
