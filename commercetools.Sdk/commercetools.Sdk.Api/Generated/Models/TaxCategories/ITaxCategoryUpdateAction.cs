using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryUpdateAction))]
    [SubTypeDiscriminator("addTaxRate", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryChangeNameAction))]
    [SubTypeDiscriminator("removeTaxRate", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    [SubTypeDiscriminator("replaceTaxRate", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.TaxCategories.TaxCategorySetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.TaxCategories.TaxCategorySetKeyAction))]
    public partial interface ITaxCategoryUpdateAction 
    {
        string Action { get; set;}
    }
}
