namespace commercetools.Api.Models.Projects
{
    public partial class CartsConfiguration : ICartsConfiguration
    {
        public bool? CountryTaxRateFallbackEnabled { get; set;}
        
        public long? DeleteDaysAfterLastModification { get; set;}
    }
}
