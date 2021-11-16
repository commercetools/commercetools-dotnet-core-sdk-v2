using commercetools.Api.Models.Zones;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodAddZoneAction : IShippingMethodAddZoneAction
    {
        public string Action { get; set; }

        public IZoneResourceIdentifier Zone { get; set; }
        public ShippingMethodAddZoneAction()
        {
            this.Action = "addZone";
        }
    }
}
