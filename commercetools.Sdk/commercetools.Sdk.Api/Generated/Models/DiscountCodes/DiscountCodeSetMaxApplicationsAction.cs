using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetMaxApplicationsAction : IDiscountCodeSetMaxApplicationsAction
    {
        public string Action { get; set; }

        public long? MaxApplications { get; set; }
        public DiscountCodeSetMaxApplicationsAction()
        {
            this.Action = "setMaxApplications";
        }
    }
}
