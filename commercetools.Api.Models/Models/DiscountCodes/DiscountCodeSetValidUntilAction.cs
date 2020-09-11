using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeSetValidUntilAction : DiscountCodeUpdateAction
    {
        public DateTime ValidUntil { get; set;}
    }
}
