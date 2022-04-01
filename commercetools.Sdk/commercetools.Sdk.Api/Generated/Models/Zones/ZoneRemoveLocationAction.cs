namespace commercetools.Sdk.Api.Models.Zones
{
    public partial class ZoneRemoveLocationAction : IZoneRemoveLocationAction
    {
        public string Action { get; set; }

        public ILocation Location { get; set; }
        public ZoneRemoveLocationAction()
        {
            this.Action = "removeLocation";
        }
    }
}
