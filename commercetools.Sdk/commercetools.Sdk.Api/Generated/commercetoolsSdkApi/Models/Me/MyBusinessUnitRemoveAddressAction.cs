namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitRemoveAddressAction : IMyBusinessUnitRemoveAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitRemoveAddressAction()
        {
            this.Action = "removeAddress";
        }
    }
}
