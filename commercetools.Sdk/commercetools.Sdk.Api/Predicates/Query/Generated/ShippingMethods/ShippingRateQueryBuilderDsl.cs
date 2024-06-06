using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingRateQueryBuilderDsl
    {
        public ShippingRateQueryBuilderDsl()
        {
        }

        public static ShippingRateQueryBuilderDsl Of()
        {
            return new ShippingRateQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ShippingRateQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                ShippingRateQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingRateQueryBuilderDsl> FreeAbove(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("freeAbove"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                ShippingRateQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShippingRateQueryBuilderDsl, bool> IsMatching()
        {
            return new ComparisonPredicateBuilder<ShippingRateQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isMatching")),
            p => new CombinationQueryPredicate<ShippingRateQueryBuilderDsl>(p, ShippingRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingRateQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRatePriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRatePriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRatePriceTierQueryBuilderDsl.Of())),
                ShippingRateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingRateQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<ShippingRateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<ShippingRateQueryBuilderDsl>(p, ShippingRateQueryBuilderDsl.Of));
        }

    }
}
