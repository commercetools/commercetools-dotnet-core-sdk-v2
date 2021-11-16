using commercetools.Api.Models.ShippingMethods;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetShippingMethodAction : ICartSetShippingMethodAction
    {
        public string Action { get; set;}
        
        public IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetShippingMethodAction()
        { 
           this.Action = "setShippingMethod";
        }
    }
}
