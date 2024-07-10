using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListUpdateActionQueryBuilderDsl
    {
        public MyShoppingListUpdateActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListUpdateActionQueryBuilderDsl Of()
        {
            return new MyShoppingListUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(p, MyShoppingListUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsAddLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListAddLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListAddLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListAddLineItemActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsAddTextLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListAddTextLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListAddTextLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListAddTextLineItemActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsChangeLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsChangeLineItemsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeNameActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsChangeTextLineItemName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsChangeTextLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsChangeTextLineItemsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsRemoveLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListRemoveLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListRemoveLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListRemoveLineItemActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsRemoveTextLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListRemoveTextLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetCustomFieldActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetCustomTypeActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetDeleteDaysAfterLastModification(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetDescriptionActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetTextLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetTextLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl> AsSetTextLineItemDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of()),
                MyShoppingListUpdateActionQueryBuilderDsl.Of);
        }
    }
}
