using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListDraft))]
    public partial interface IMyShoppingListDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        List<IShoppingListLineItemDraft> LineItems { get; set; }

        List<ITextLineItemDraft> TextLineItems { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        IStoreResourceIdentifier Store { get; set; }
    }
}
