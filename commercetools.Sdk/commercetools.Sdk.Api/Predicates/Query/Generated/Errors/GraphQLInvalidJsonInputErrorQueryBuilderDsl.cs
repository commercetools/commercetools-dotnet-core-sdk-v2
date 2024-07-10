using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidJsonInputErrorQueryBuilderDsl
    {
        public GraphQLInvalidJsonInputErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidJsonInputErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidJsonInputErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidJsonInputErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidJsonInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidJsonInputErrorQueryBuilderDsl>(p, GraphQLInvalidJsonInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLInvalidJsonInputErrorQueryBuilderDsl, string> DetailedErrorMessage()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidJsonInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("detailedErrorMessage")),
            p => new CombinationQueryPredicate<GraphQLInvalidJsonInputErrorQueryBuilderDsl>(p, GraphQLInvalidJsonInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
