using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    public partial interface IDiscountCodeChangeIsActiveAction : IDiscountCodeUpdateAction
    {
        bool IsActive { get; set; }
    }
}
