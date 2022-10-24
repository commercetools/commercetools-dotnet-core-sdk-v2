namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitSetDefaultBillingAddressAction : IMyBusinessUnitSetDefaultBillingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitSetDefaultBillingAddressAction()
        {
            this.Action = "setDefaultBillingAddress";
        }
    }
}
