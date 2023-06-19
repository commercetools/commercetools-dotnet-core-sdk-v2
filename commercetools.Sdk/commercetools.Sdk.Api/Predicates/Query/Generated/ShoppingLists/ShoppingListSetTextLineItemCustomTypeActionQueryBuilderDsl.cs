using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl
    {
        public ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                ShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
