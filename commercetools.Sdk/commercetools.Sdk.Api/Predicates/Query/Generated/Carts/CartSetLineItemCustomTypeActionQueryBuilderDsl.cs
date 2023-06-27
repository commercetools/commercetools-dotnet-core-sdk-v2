using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemCustomTypeActionQueryBuilderDsl
    {
        public CartSetLineItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl>(p, CartSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl>(p, CartSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl>(p, CartSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                CartSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                CartSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
