using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeSetMaxApplicationsAction : DiscountCodeUpdateAction
    {
        public long MaxApplications { get; set;}
    }
}
