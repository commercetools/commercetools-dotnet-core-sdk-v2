using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeChangeGroupsAction : DiscountCodeUpdateAction
    {
        public List<string> Groups { get; set;}
    }
}
