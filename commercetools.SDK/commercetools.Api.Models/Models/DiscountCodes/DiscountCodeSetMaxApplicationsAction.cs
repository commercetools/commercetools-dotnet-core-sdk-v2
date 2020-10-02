using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setMaxApplications")]
    public partial class DiscountCodeSetMaxApplicationsAction : DiscountCodeUpdateAction
    {
        public long MaxApplications { get; set;}
        public DiscountCodeSetMaxApplicationsAction()
        { 
           this.Action = "setMaxApplications";
        }
    }
}
