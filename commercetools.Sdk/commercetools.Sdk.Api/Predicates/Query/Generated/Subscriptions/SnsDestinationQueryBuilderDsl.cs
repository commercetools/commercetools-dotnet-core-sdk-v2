using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SnsDestinationQueryBuilderDsl
    {
        public SnsDestinationQueryBuilderDsl()
        {
        }

        public static SnsDestinationQueryBuilderDsl Of()
        {
            return new SnsDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<SnsDestinationQueryBuilderDsl>(p, SnsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string> AccessKey()
        {
            return new ComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessKey")),
            p => new CombinationQueryPredicate<SnsDestinationQueryBuilderDsl>(p, SnsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string> AccessSecret()
        {
            return new ComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessSecret")),
            p => new CombinationQueryPredicate<SnsDestinationQueryBuilderDsl>(p, SnsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string> TopicArn()
        {
            return new ComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("topicArn")),
            p => new CombinationQueryPredicate<SnsDestinationQueryBuilderDsl>(p, SnsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string> AuthenticationMode()
        {
            return new ComparisonPredicateBuilder<SnsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authenticationMode")),
            p => new CombinationQueryPredicate<SnsDestinationQueryBuilderDsl>(p, SnsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
