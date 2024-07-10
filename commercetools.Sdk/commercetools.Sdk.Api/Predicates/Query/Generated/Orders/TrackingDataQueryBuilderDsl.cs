// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class TrackingDataQueryBuilderDsl
    {
        public TrackingDataQueryBuilderDsl()
        {
        }

        public static TrackingDataQueryBuilderDsl Of()
        {
            return new TrackingDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string> TrackingId()
        {
            return new ComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("trackingId")),
            p => new CombinationQueryPredicate<TrackingDataQueryBuilderDsl>(p, TrackingDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string> Carrier()
        {
            return new ComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("carrier")),
            p => new CombinationQueryPredicate<TrackingDataQueryBuilderDsl>(p, TrackingDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string> Provider()
        {
            return new ComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("provider")),
            p => new CombinationQueryPredicate<TrackingDataQueryBuilderDsl>(p, TrackingDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string> ProviderTransaction()
        {
            return new ComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("providerTransaction")),
            p => new CombinationQueryPredicate<TrackingDataQueryBuilderDsl>(p, TrackingDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, bool> IsReturn()
        {
            return new ComparisonPredicateBuilder<TrackingDataQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isReturn")),
            p => new CombinationQueryPredicate<TrackingDataQueryBuilderDsl>(p, TrackingDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
