

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitRemoveBillingAddressIdAction : IMyBusinessUnitRemoveBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitRemoveBillingAddressIdAction()
        {
            this.Action = "removeBillingAddressId";
        }
    }
}
