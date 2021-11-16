using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction))]
    public partial interface IDiscountCodeSetValidFromAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidFrom { get; set; }
    }
}
