using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction))]
    public partial interface IDiscountCodeSetValidUntilAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidUntil { get; set; }
    }
}
