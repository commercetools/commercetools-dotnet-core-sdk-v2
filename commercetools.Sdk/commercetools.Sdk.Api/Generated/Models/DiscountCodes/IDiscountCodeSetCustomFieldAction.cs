using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction))]
    public partial interface IDiscountCodeSetCustomFieldAction : IDiscountCodeUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
