using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction))]
    public partial interface IDiscountCodeSetValidFromAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidFrom { get; set; }

    }
}
