using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListDraft))]
    public partial interface IMyShoppingListDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<IShoppingListLineItemDraft> LineItems { get; set; }

        IEnumerable<IShoppingListLineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }

        IList<ITextLineItemDraft> TextLineItems { get; set; }

        IEnumerable<ITextLineItemDraft> TextLineItemsEnumerable { set => TextLineItems = value.ToList(); }

        ICustomFieldsDraft Custom { get; set; }

        int? DeleteDaysAfterLastModification { get; set; }

        IStoreResourceIdentifier Store { get; set; }

    }
}
