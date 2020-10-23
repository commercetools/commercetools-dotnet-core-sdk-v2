using commercetools.Api.Generated.Models.CartDiscounts;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CartDiscounts
{
    public interface ICartDiscountSetDescriptionAction : ICartDiscountUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
