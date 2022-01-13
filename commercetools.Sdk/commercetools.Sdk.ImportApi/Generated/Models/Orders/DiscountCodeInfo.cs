using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeKeyReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
