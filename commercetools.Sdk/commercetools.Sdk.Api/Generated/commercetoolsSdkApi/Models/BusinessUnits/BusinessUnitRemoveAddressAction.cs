

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitRemoveAddressAction : IBusinessUnitRemoveAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitRemoveAddressAction()
        {
            this.Action = "removeAddress";
        }
    }
}
