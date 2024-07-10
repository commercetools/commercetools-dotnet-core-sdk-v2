using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl
    {
        public ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                ShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
