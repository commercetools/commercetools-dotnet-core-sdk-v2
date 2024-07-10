using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class GoogleCloudPubSubDestinationQueryBuilderDsl
    {
        public GoogleCloudPubSubDestinationQueryBuilderDsl()
        {
        }

        public static GoogleCloudPubSubDestinationQueryBuilderDsl Of()
        {
            return new GoogleCloudPubSubDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GoogleCloudPubSubDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<GoogleCloudPubSubDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<GoogleCloudPubSubDestinationQueryBuilderDsl>(p, GoogleCloudPubSubDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GoogleCloudPubSubDestinationQueryBuilderDsl, string> ProjectId()
        {
            return new ComparisonPredicateBuilder<GoogleCloudPubSubDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectId")),
            p => new CombinationQueryPredicate<GoogleCloudPubSubDestinationQueryBuilderDsl>(p, GoogleCloudPubSubDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GoogleCloudPubSubDestinationQueryBuilderDsl, string> Topic()
        {
            return new ComparisonPredicateBuilder<GoogleCloudPubSubDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("topic")),
            p => new CombinationQueryPredicate<GoogleCloudPubSubDestinationQueryBuilderDsl>(p, GoogleCloudPubSubDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
