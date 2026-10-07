using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class AbsoluteAllocation : IAbsoluteAllocation
    {
        public string Type { get; set; }

        public IHighPrecisionMoney Amount { get; set; }
        public AbsoluteAllocation()
        {
            this.Type = "Absolute";
        }
    }
}
