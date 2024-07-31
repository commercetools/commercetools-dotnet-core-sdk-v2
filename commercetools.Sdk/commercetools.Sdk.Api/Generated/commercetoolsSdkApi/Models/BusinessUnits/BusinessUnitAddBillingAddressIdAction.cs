

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddBillingAddressIdAction : IBusinessUnitAddBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitAddBillingAddressIdAction()
        {
            this.Action = "addBillingAddressId";
        }
    }
}
