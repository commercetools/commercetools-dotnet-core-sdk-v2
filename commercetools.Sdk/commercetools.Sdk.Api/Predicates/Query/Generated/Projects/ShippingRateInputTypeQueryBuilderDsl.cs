using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ShippingRateInputTypeQueryBuilderDsl
    {
        public ShippingRateInputTypeQueryBuilderDsl()
        {
        }

        public static ShippingRateInputTypeQueryBuilderDsl Of()
        {
            return new ShippingRateInputTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingRateInputTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShippingRateInputTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl>(p, ShippingRateInputTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl> AsCartClassification(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.CartClassificationTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.CartClassificationTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.CartClassificationTypeQueryBuilderDsl.Of()),
                ShippingRateInputTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl> AsCartScore(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.CartScoreTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.CartScoreTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.CartScoreTypeQueryBuilderDsl.Of()),
                ShippingRateInputTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl> AsCartValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.CartValueTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.CartValueTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.CartValueTypeQueryBuilderDsl.Of()),
                ShippingRateInputTypeQueryBuilderDsl.Of);
        }
    }
}
