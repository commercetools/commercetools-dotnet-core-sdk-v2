

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitAddBillingAddressIdAction : IMyBusinessUnitAddBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitAddBillingAddressIdAction()
        {
            this.Action = "addBillingAddressId";
        }
    }
}
