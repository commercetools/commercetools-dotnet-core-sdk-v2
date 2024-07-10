using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class QueryTimedOutErrorQueryBuilderDsl
    {
        public QueryTimedOutErrorQueryBuilderDsl()
        {
        }

        public static QueryTimedOutErrorQueryBuilderDsl Of()
        {
            return new QueryTimedOutErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QueryTimedOutErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<QueryTimedOutErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<QueryTimedOutErrorQueryBuilderDsl>(p, QueryTimedOutErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QueryTimedOutErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<QueryTimedOutErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<QueryTimedOutErrorQueryBuilderDsl>(p, QueryTimedOutErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
