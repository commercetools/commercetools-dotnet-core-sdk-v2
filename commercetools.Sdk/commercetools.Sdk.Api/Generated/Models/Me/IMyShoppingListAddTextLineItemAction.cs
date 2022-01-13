using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListAddTextLineItemAction))]
    public partial interface IMyShoppingListAddTextLineItemAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
