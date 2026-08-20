using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class EstimatedDeliveryQueryBuilderDsl
    {
        public EstimatedDeliveryQueryBuilderDsl()
        {
        }

        public static EstimatedDeliveryQueryBuilderDsl Of()
        {
            return new EstimatedDeliveryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EstimatedDeliveryQueryBuilderDsl, DateTime> From()
        {
            return new ComparisonPredicateBuilder<EstimatedDeliveryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("from")),
            p => new CombinationQueryPredicate<EstimatedDeliveryQueryBuilderDsl>(p, EstimatedDeliveryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EstimatedDeliveryQueryBuilderDsl, DateTime> Until()
        {
            return new ComparisonPredicateBuilder<EstimatedDeliveryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("until")),
            p => new CombinationQueryPredicate<EstimatedDeliveryQueryBuilderDsl>(p, EstimatedDeliveryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
