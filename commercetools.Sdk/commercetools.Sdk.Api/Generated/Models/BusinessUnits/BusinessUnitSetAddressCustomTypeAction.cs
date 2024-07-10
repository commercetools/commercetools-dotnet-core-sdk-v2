using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetAddressCustomTypeAction : IBusinessUnitSetAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }

        public string AddressId { get; set; }
        public BusinessUnitSetAddressCustomTypeAction()
        {
            this.Action = "setAddressCustomType";
        }
    }
}
