namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetDefaultShippingAddressAction : IBusinessUnitSetDefaultShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitSetDefaultShippingAddressAction()
        {
            this.Action = "setDefaultShippingAddress";
        }
    }
}
