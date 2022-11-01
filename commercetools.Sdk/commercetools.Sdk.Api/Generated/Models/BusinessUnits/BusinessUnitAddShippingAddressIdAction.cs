namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddShippingAddressIdAction : IBusinessUnitAddShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitAddShippingAddressIdAction()
        {
            this.Action = "addShippingAddressId";
        }
    }
}
