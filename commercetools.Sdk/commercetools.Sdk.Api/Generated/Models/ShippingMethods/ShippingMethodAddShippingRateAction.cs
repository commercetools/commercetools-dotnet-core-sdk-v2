using commercetools.Api.Models.Zones;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodAddShippingRateAction : IShippingMethodAddShippingRateAction
    {
        public string Action { get; set;}
        
        public IZoneResourceIdentifier Zone { get; set;}
        
        public IShippingRateDraft ShippingRate { get; set;}
        public ShippingMethodAddShippingRateAction()
        { 
           this.Action = "addShippingRate";
        }
    }
}
