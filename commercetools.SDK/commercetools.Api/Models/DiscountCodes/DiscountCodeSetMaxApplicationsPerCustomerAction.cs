using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setMaxApplicationsPerCustomer")]
    public partial class DiscountCodeSetMaxApplicationsPerCustomerAction : DiscountCodeUpdateAction
    {
        public long MaxApplicationsPerCustomer { get; set;}
        public DiscountCodeSetMaxApplicationsPerCustomerAction()
        { 
           this.Action = "setMaxApplicationsPerCustomer";
        }
    }
}
