using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.TextLineItemDraft))]
    public partial interface ITextLineItemDraft
    {
        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString Name { get; set; }

        int? Quantity { get; set; }
    }
}
