using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ShippingRateInputQueryBuilderDsl
    {
        public ShippingRateInputQueryBuilderDsl()
        {
        }

        public static ShippingRateInputQueryBuilderDsl Of()
        {
            return new ShippingRateInputQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingRateInputQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShippingRateInputQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShippingRateInputQueryBuilderDsl>(p, ShippingRateInputQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShippingRateInputQueryBuilderDsl> AsClassification(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ClassificationShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ClassificationShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ClassificationShippingRateInputQueryBuilderDsl.Of()),
                ShippingRateInputQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingRateInputQueryBuilderDsl> AsScore(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ScoreShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ScoreShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ScoreShippingRateInputQueryBuilderDsl.Of()),
                ShippingRateInputQueryBuilderDsl.Of);
        }
    }
}
