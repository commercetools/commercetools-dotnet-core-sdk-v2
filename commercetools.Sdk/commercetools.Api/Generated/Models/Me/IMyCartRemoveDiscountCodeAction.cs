using commercetools.Api.Generated.Models.DiscountCodes;
using commercetools.Api.Generated.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyCartRemoveDiscountCodeAction : IMyCartUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set;}
    }
}
