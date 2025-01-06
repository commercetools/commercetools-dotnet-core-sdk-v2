using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountPatternTargetQueryBuilderDsl
    {
        public CartDiscountPatternTargetQueryBuilderDsl()
        {
        }

        public static CartDiscountPatternTargetQueryBuilderDsl Of()
        {
            return new CartDiscountPatternTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(p, CartDiscountPatternTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl> TriggerPattern(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.PatternComponentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.PatternComponentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("triggerPattern"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.PatternComponentQueryBuilderDsl.Of())),
                CartDiscountPatternTargetQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl> TriggerPattern()
        {
            return new CollectionPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("triggerPattern")),
                    p => new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(p, CartDiscountPatternTargetQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl> TargetPattern(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.PatternComponentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.PatternComponentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("targetPattern"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.PatternComponentQueryBuilderDsl.Of())),
                CartDiscountPatternTargetQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl> TargetPattern()
        {
            return new CollectionPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("targetPattern")),
                    p => new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(p, CartDiscountPatternTargetQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl, long> MaxOccurrence()
        {
            return new ComparisonPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxOccurrence")),
            p => new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(p, CartDiscountPatternTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl, string> SelectionMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountPatternTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("selectionMode")),
            p => new CombinationQueryPredicate<CartDiscountPatternTargetQueryBuilderDsl>(p, CartDiscountPatternTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
