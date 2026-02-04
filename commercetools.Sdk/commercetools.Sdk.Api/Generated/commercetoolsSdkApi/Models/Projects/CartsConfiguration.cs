using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class CartsConfiguration : ICartsConfiguration
    {
        public long DeleteDaysAfterLastModification { get; set; }

        public bool? CountryTaxRateFallbackEnabled { get; set; }

        public IRoundingMode PriceRoundingMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }
    }
}
