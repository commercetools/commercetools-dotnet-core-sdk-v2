using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetAssociatesAction : IBusinessUnitSetAssociatesAction
    {
        public string Action { get; set; }

        public List<IAssociateDraft> Associates { get; set; }
        public BusinessUnitSetAssociatesAction()
        {
            this.Action = "setAssociates";
        }
    }
}
