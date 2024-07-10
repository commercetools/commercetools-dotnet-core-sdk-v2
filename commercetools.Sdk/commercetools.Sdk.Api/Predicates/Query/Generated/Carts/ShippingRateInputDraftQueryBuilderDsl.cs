using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ShippingRateInputDraftQueryBuilderDsl
    {
        public ShippingRateInputDraftQueryBuilderDsl()
        {
        }

        public static ShippingRateInputDraftQueryBuilderDsl Of()
        {
            return new ShippingRateInputDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingRateInputDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShippingRateInputDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShippingRateInputDraftQueryBuilderDsl>(p, ShippingRateInputDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShippingRateInputDraftQueryBuilderDsl> AsClassification(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ClassificationShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ClassificationShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ClassificationShippingRateInputDraftQueryBuilderDsl.Of()),
                ShippingRateInputDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShippingRateInputDraftQueryBuilderDsl> AsScore(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ScoreShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ScoreShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateInputDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ScoreShippingRateInputDraftQueryBuilderDsl.Of()),
                ShippingRateInputDraftQueryBuilderDsl.Of);
        }
    }
}
