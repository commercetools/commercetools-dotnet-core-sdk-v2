namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitRemoveShippingAddressIdAction : IBusinessUnitRemoveShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitRemoveShippingAddressIdAction()
        {
            this.Action = "removeShippingAddressId";
        }
    }
}
