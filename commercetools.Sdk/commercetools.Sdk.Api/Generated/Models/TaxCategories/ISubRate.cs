using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.SubRate))]
    public partial interface ISubRate 
    {
        string Name { get; set;}
        
        double Amount { get; set;}
    }
}
