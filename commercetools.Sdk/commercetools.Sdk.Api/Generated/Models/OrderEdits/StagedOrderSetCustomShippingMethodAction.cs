using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomShippingMethodAction : IStagedOrderSetCustomShippingMethodAction
    {
        public string Action { get; set;}
        
        public string ShippingMethodName { get; set;}
        
        public IShippingRateDraft ShippingRate { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetCustomShippingMethodAction()
        { 
           this.Action = "setCustomShippingMethod";
        }
    }
}
