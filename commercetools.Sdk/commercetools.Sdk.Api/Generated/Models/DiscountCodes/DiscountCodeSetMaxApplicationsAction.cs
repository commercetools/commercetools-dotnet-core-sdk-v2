using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetMaxApplicationsAction : IDiscountCodeSetMaxApplicationsAction
    {
        public string Action { get; set;}
        
        public long? MaxApplications { get; set;}
        public DiscountCodeSetMaxApplicationsAction()
        { 
           this.Action = "setMaxApplications";
        }
    }
}
