using commercetools.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction))]
    public partial interface IShippingMethodChangeTaxCategoryAction : IShippingMethodUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set; }
    }
}
