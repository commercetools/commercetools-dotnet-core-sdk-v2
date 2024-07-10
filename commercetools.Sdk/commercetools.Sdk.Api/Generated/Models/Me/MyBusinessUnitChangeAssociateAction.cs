using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitChangeAssociateAction : IMyBusinessUnitChangeAssociateAction
    {
        public string Action { get; set; }

        public IAssociateDraft Associate { get; set; }
        public MyBusinessUnitChangeAssociateAction()
        {
            this.Action = "changeAssociate";
        }
    }
}
