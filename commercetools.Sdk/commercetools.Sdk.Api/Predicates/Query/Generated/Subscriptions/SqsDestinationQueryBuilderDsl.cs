using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SqsDestinationQueryBuilderDsl
    {
        public SqsDestinationQueryBuilderDsl()
        {
        }

        public static SqsDestinationQueryBuilderDsl Of()
        {
            return new SqsDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<SqsDestinationQueryBuilderDsl>(p, SqsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string> AccessKey()
        {
            return new ComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessKey")),
            p => new CombinationQueryPredicate<SqsDestinationQueryBuilderDsl>(p, SqsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string> AccessSecret()
        {
            return new ComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessSecret")),
            p => new CombinationQueryPredicate<SqsDestinationQueryBuilderDsl>(p, SqsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string> QueueUrl()
        {
            return new ComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("queueUrl")),
            p => new CombinationQueryPredicate<SqsDestinationQueryBuilderDsl>(p, SqsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string> Region()
        {
            return new ComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("region")),
            p => new CombinationQueryPredicate<SqsDestinationQueryBuilderDsl>(p, SqsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string> AuthenticationMode()
        {
            return new ComparisonPredicateBuilder<SqsDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authenticationMode")),
            p => new CombinationQueryPredicate<SqsDestinationQueryBuilderDsl>(p, SqsDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
