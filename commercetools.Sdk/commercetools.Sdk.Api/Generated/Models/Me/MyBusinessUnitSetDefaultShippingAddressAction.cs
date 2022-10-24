namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitSetDefaultShippingAddressAction : IMyBusinessUnitSetDefaultShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitSetDefaultShippingAddressAction()
        {
            this.Action = "setDefaultShippingAddress";
        }
    }
}
