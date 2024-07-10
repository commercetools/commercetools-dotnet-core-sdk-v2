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

    public partial class MyBusinessUnitChangeParentUnitAction : IMyBusinessUnitChangeParentUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier ParentUnit { get; set; }
        public MyBusinessUnitChangeParentUnitAction()
        {
            this.Action = "changeParentUnit";
        }
    }
}
