using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction))]
    public partial interface IShippingMethodChangeTaxCategoryAction : IShippingMethodUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

    }
}
