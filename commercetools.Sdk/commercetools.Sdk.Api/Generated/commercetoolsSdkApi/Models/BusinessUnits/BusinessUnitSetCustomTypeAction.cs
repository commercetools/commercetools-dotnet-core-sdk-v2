using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetCustomTypeAction : IBusinessUnitSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public BusinessUnitSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
