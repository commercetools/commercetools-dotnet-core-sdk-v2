using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListUpdateActionQueryBuilderDsl
    {
        public ShoppingListUpdateActionQueryBuilderDsl()
        {
        }

        public static ShoppingListUpdateActionQueryBuilderDsl Of()
        {
            return new ShoppingListUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(p, ShoppingListUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsAddLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListAddLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListAddLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListAddLineItemActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsAddTextLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListAddTextLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListAddTextLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListAddTextLineItemActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsChangeLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsChangeLineItemsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeLineItemsOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeLineItemsOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeLineItemsOrderActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeNameActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsChangeTextLineItemName(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsChangeTextLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsChangeTextLineItemsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsRemoveLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListRemoveLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListRemoveLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListRemoveLineItemActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsRemoveTextLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListRemoveTextLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListRemoveTextLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetAnonymousId(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetAnonymousIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetAnonymousIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetAnonymousIdActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomFieldActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomTypeActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomerActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomerActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetCustomerActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetDeleteDaysAfterLastModification(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetDescriptionActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetKeyActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetSlug(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetSlugActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetSlugActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetSlugActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetStore(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetStoreActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetTextLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetTextLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl> AsSetTextLineItemDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of()),
                ShoppingListUpdateActionQueryBuilderDsl.Of);
        }
    }
}
