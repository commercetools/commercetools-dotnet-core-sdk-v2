using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeStatusAction : IBusinessUnitChangeStatusAction
    {
        public string Action { get; set; }

        public string Status { get; set; }
        public BusinessUnitChangeStatusAction()
        {
            this.Action = "changeStatus";
        }
    }
}
