using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetBusinessUnitAction : IMyCartSetBusinessUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }
        public MyCartSetBusinessUnitAction()
        {
            this.Action = "setBusinessUnit";
        }
    }
}
