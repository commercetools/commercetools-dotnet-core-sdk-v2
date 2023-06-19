using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        decimal Amount { get; set; }

    }
}
