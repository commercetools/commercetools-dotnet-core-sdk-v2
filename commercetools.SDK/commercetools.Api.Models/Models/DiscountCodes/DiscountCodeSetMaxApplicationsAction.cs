using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setMaxApplications")]
    public class DiscountCodeSetMaxApplicationsAction : DiscountCodeUpdateAction
    {
        public long MaxApplications { get; set;}
    }
}
