namespace commercetools.Sdk.Api.Models.Common
{

    public partial class PriceTier : IPriceTier
    {
        public long MinimumQuantity { get; set; }

        public ITypedMoney Value { get; set; }
    }
}
