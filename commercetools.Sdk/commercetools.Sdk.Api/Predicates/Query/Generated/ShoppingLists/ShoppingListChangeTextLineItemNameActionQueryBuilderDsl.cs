using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemNameActionQueryBuilderDsl
    {
        public ShoppingListChangeTextLineItemNameActionQueryBuilderDsl()
        {
        }

        public static ShoppingListChangeTextLineItemNameActionQueryBuilderDsl Of()
        {
            return new ShoppingListChangeTextLineItemNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of);
        }


    }
}
