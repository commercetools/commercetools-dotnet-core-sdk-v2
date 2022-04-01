namespace commercetools.Sdk.Api.Models.Zones
{
    public partial class ZoneSetDescriptionAction : IZoneSetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ZoneSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
