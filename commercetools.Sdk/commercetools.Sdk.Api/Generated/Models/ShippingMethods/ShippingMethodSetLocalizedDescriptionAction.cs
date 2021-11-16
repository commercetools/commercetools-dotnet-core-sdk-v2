using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodSetLocalizedDescriptionAction : IShippingMethodSetLocalizedDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString LocalizedDescription { get; set;}
        public ShippingMethodSetLocalizedDescriptionAction()
        { 
           this.Action = "setLocalizedDescription";
        }
    }
}
