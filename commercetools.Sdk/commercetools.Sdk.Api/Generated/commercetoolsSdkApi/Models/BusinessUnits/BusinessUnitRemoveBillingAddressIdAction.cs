

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitRemoveBillingAddressIdAction : IBusinessUnitRemoveBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitRemoveBillingAddressIdAction()
        {
            this.Action = "removeBillingAddressId";
        }
    }
}
