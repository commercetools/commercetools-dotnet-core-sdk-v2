using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLConcurrentModificationErrorQueryBuilderDsl
    {
        public GraphQLConcurrentModificationErrorQueryBuilderDsl()
        {
        }

        public static GraphQLConcurrentModificationErrorQueryBuilderDsl Of()
        {
            return new GraphQLConcurrentModificationErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLConcurrentModificationErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLConcurrentModificationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLConcurrentModificationErrorQueryBuilderDsl>(p, GraphQLConcurrentModificationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLConcurrentModificationErrorQueryBuilderDsl, long> CurrentVersion()
        {
            return new ComparisonPredicateBuilder<GraphQLConcurrentModificationErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currentVersion")),
            p => new CombinationQueryPredicate<GraphQLConcurrentModificationErrorQueryBuilderDsl>(p, GraphQLConcurrentModificationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
