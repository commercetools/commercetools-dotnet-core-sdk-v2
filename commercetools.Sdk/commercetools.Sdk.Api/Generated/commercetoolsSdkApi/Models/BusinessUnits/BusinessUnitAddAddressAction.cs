using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddAddressAction : IBusinessUnitAddAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public BusinessUnitAddAddressAction()
        {
            this.Action = "addAddress";
        }
    }
}
