namespace commercetools.Sdk.Api.Models.BusinessUnits
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
