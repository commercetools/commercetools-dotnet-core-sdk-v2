using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSearchExecutionFailureErrorQueryBuilderDsl
    {
        public GraphQLSearchExecutionFailureErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSearchExecutionFailureErrorQueryBuilderDsl Of()
        {
            return new GraphQLSearchExecutionFailureErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSearchExecutionFailureErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSearchExecutionFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSearchExecutionFailureErrorQueryBuilderDsl>(p, GraphQLSearchExecutionFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
