using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setName")]
    public class DiscountCodeSetNameAction : DiscountCodeUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
