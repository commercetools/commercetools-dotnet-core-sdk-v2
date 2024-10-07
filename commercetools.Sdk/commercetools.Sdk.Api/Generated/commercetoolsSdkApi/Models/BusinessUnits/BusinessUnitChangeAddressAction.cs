using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeAddressAction : IBusinessUnitChangeAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }

        public IBaseAddress Address { get; set; }
        public BusinessUnitChangeAddressAction()
        {
            this.Action = "changeAddress";
        }
    }
}
