using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        double Amount { get; set; }
    }
}
