using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class TaxPortionDraft : ITaxPortionDraft
    {
        public string Name { get; set; }

        public double Rate { get; set; }

        public IMoney Amount { get; set; }
    }
}
