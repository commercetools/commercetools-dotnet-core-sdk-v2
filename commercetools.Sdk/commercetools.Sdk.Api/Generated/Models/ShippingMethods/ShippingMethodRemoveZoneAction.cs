using commercetools.Sdk.Api.Models.Zones;


namespace commercetools.Sdk.Api.Models.ShippingMethods
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
