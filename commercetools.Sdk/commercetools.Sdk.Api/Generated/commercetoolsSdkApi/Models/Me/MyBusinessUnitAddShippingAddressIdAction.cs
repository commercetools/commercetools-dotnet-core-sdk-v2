

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitAddShippingAddressIdAction : IMyBusinessUnitAddShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyBusinessUnitAddShippingAddressIdAction()
        {
            this.Action = "addShippingAddressId";
        }
    }
}
