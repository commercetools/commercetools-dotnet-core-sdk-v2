using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction))]
    public partial interface IDiscountCodeSetValidFromAndUntilAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }
    }
}
