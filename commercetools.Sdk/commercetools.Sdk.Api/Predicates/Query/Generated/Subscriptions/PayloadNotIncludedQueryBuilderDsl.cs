using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class PayloadNotIncludedQueryBuilderDsl
    {
        public PayloadNotIncludedQueryBuilderDsl()
        {
        }

        public static PayloadNotIncludedQueryBuilderDsl Of()
        {
            return new PayloadNotIncludedQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PayloadNotIncludedQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<PayloadNotIncludedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<PayloadNotIncludedQueryBuilderDsl>(p, PayloadNotIncludedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PayloadNotIncludedQueryBuilderDsl, string> PayloadType()
        {
            return new ComparisonPredicateBuilder<PayloadNotIncludedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("payloadType")),
            p => new CombinationQueryPredicate<PayloadNotIncludedQueryBuilderDsl>(p, PayloadNotIncludedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
