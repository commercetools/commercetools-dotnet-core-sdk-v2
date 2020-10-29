using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetMaxApplicationsPerCustomerAction : IDiscountCodeSetMaxApplicationsPerCustomerAction
    {
        public string Action { get; set;}
        
        public long? MaxApplicationsPerCustomer { get; set;}
        public DiscountCodeSetMaxApplicationsPerCustomerAction()
        { 
           this.Action = "setMaxApplicationsPerCustomer";
        }
    }
}
