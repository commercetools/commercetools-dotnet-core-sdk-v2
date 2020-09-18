using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("changeIsActive")]
    public class DiscountCodeChangeIsActiveAction : DiscountCodeUpdateAction
    {
        public bool IsActive { get; set;}
    }
}
