namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitRemoveShippingAddressIdAction : IMyBusinessUnitRemoveShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitRemoveShippingAddressIdAction()
        {
            this.Action = "removeShippingAddressId";
        }
    }
}
