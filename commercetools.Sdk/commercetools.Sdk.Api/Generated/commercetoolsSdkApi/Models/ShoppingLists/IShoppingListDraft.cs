using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListDraft))]
    public partial interface IShoppingListDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ICustomerResourceIdentifier Customer { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        string AnonymousId { get; set; }

        int? DeleteDaysAfterLastModification { get; set; }

        IList<IShoppingListLineItemDraft> LineItems { get; set; }

        IEnumerable<IShoppingListLineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }

        IList<ITextLineItemDraft> TextLineItems { get; set; }

        IEnumerable<ITextLineItemDraft> TextLineItemsEnumerable { set => TextLineItems = value.ToList(); }

        IStoreResourceIdentifier Store { get; set; }

        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
