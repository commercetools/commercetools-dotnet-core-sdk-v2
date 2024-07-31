

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetDefaultBillingAddressAction : IBusinessUnitSetDefaultBillingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitSetDefaultBillingAddressAction()
        {
            this.Action = "setDefaultBillingAddress";
        }
    }
}
