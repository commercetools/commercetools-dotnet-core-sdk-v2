using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdateAction))]
    [SubTypeDiscriminator("addTaxRate", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryChangeNameAction))]
    [SubTypeDiscriminator("removeTaxRate", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    [SubTypeDiscriminator("replaceTaxRate", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetKeyAction))]
    public partial interface ITaxCategoryUpdateAction
    {
        string Action { get; set; }
    }
}
