using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction))]
    public partial interface ICartDiscountSetCustomFieldAction : ICartDiscountUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
