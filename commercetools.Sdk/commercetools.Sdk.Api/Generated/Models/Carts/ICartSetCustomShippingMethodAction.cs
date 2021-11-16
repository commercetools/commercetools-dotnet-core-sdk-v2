using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomShippingMethodAction))]
    public partial interface ICartSetCustomShippingMethodAction : ICartUpdateAction
    {
        string ShippingMethodName { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
