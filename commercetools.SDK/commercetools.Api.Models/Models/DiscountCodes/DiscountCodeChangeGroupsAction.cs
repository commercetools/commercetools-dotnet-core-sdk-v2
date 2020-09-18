using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("changeGroups")]
    public class DiscountCodeChangeGroupsAction : DiscountCodeUpdateAction
    {
        public List<string> Groups { get; set;}
    }
}
