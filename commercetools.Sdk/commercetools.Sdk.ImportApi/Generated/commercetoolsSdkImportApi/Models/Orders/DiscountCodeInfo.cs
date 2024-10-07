using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeKeyReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
