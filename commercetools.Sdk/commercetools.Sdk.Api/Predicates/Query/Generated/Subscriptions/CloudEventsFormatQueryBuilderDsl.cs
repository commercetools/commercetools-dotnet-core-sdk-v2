using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class CloudEventsFormatQueryBuilderDsl
    {
        public CloudEventsFormatQueryBuilderDsl()
        {
        }

        public static CloudEventsFormatQueryBuilderDsl Of()
        {
            return new CloudEventsFormatQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CloudEventsFormatQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CloudEventsFormatQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CloudEventsFormatQueryBuilderDsl>(p, CloudEventsFormatQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsFormatQueryBuilderDsl, string> CloudEventsVersion()
        {
            return new ComparisonPredicateBuilder<CloudEventsFormatQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cloudEventsVersion")),
            p => new CombinationQueryPredicate<CloudEventsFormatQueryBuilderDsl>(p, CloudEventsFormatQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
