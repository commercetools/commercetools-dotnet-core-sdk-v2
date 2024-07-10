using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInternalConstraintViolatedErrorQueryBuilderDsl
    {
        public GraphQLInternalConstraintViolatedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInternalConstraintViolatedErrorQueryBuilderDsl Of()
        {
            return new GraphQLInternalConstraintViolatedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInternalConstraintViolatedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInternalConstraintViolatedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInternalConstraintViolatedErrorQueryBuilderDsl>(p, GraphQLInternalConstraintViolatedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
