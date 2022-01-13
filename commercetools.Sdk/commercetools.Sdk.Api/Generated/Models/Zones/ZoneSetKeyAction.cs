namespace commercetools.Api.Models.Zones
{
    public partial class ZoneSetKeyAction : IZoneSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ZoneSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
