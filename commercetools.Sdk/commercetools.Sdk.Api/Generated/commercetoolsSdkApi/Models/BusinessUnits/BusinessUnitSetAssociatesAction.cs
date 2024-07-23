using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetAssociatesAction : IBusinessUnitSetAssociatesAction
    {
        public string Action { get; set; }

        public IList<IAssociateDraft> Associates { get; set; }
        public IEnumerable<IAssociateDraft> AssociatesEnumerable { set => Associates = value.ToList(); }

        public BusinessUnitSetAssociatesAction()
        {
            this.Action = "setAssociates";
        }
    }
}
