using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction))]
    public partial interface IDiscountCodeSetCustomFieldAction : IDiscountCodeUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
