using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class AbsoluteAllocationDraft : IAbsoluteAllocationDraft
    {
        public string Type { get; set; }

        public IHighPrecisionMoneyDraft Amount { get; set; }
        public AbsoluteAllocationDraft()
        {
            this.Type = "Absolute";
        }
    }
}
