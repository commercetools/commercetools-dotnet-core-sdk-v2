using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitSetAddressCustomTypeAction : IMyBusinessUnitSetAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }

        public string AddressId { get; set; }
        public MyBusinessUnitSetAddressCustomTypeAction()
        {
            this.Action = "setAddressCustomType";
        }
    }
}
