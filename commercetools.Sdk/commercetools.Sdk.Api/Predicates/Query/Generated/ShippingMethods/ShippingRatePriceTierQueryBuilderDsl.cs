using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingRatePriceTierQueryBuilderDsl
    {
        public ShippingRatePriceTierQueryBuilderDsl()
        {
        }

        public static ShippingRatePriceTierQueryBuilderDsl Of()
        {
            return new ShippingRatePriceTierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingRatePriceTierQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShippingRatePriceTierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl>(p, ShippingRatePriceTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl> AsCartClassification(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartClassificationTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartClassificationTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartClassificationTierQueryBuilderDsl.Of()),
                ShippingRatePriceTierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl> AsCartScore(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartScoreTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartScoreTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartScoreTierQueryBuilderDsl.Of()),
                ShippingRatePriceTierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl> AsCartValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartValueTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartValueTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRatePriceTierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.CartValueTierQueryBuilderDsl.Of()),
                ShippingRatePriceTierQueryBuilderDsl.Of);
        }
    }
}
