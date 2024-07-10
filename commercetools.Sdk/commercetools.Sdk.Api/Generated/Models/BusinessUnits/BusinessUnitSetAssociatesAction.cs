using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
