namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneAddLocationAction : IZoneAddLocationAction
    {
        public string Action { get; set; }

        public ILocation Location { get; set; }
        public ZoneAddLocationAction()
        {
            this.Action = "addLocation";
        }
    }
}
