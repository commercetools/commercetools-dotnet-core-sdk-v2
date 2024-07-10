using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLLockedFieldErrorQueryBuilderDsl
    {
        public GraphQLLockedFieldErrorQueryBuilderDsl()
        {
        }

        public static GraphQLLockedFieldErrorQueryBuilderDsl Of()
        {
            return new GraphQLLockedFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLLockedFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLLockedFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLLockedFieldErrorQueryBuilderDsl>(p, GraphQLLockedFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLockedFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<GraphQLLockedFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<GraphQLLockedFieldErrorQueryBuilderDsl>(p, GraphQLLockedFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
