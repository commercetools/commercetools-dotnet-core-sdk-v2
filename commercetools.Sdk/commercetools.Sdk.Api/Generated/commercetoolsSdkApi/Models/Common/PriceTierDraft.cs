namespace commercetools.Sdk.Api.Models.Common
{

    public partial class PriceTierDraft : IPriceTierDraft
    {
        public long MinimumQuantity { get; set; }

        public IMoney Value { get; set; }
    }
}
