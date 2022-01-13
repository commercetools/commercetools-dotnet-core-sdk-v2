using commercetools.Api.Models.Zones;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodRemoveZoneAction : IShippingMethodRemoveZoneAction
    {
        public string Action { get; set; }

        public IZoneResourceIdentifier Zone { get; set; }
        public ShippingMethodRemoveZoneAction()
        {
            this.Action = "removeZone";
        }
    }
}
