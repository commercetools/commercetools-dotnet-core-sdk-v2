using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountedLineItemPortionDraft : IDiscountedLineItemPortionDraft
    {
        public IReference Discount { get; set; }

        public ITypedMoneyDraft DiscountedAmount { get; set; }
    }
}
