using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeAssociateModeAction : IBusinessUnitChangeAssociateModeAction
    {
        public string Action { get; set; }

        public IBusinessUnitAssociateMode AssociateMode { get; set; }
        public BusinessUnitChangeAssociateModeAction()
        {
            this.Action = "changeAssociateMode";
        }
    }
}
