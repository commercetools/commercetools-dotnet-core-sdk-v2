using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction))]
    public partial interface IDiscountCodeSetValidUntilAction : IDiscountCodeUpdateAction
    {
        DateTime ValidUntil { get; set;}
    }
}
