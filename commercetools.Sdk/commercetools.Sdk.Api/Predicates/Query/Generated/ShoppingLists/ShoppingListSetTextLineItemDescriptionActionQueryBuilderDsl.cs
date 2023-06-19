using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl
    {
        public ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
