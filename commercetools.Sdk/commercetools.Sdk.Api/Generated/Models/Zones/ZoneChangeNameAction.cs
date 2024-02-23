namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneChangeNameAction : IZoneChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ZoneChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
