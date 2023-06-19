using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListAddTextLineItemAction))]
    public partial interface IMyShoppingListAddTextLineItemAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
