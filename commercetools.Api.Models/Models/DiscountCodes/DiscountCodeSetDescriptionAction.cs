using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeSetDescriptionAction : DiscountCodeUpdateAction
    {
        public LocalizedString Description { get; set;}
    }
}
