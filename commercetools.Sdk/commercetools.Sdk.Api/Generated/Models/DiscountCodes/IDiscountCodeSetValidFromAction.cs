using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction))]
    public partial interface IDiscountCodeSetValidFromAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidFrom { get; set;}
    }
}
