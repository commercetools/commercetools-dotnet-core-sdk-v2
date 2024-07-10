using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl
    {
        public GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl Of()
        {
            return new GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl>(p, GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl, string> InvalidAttributeName()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("invalidAttributeName")),
            p => new CombinationQueryPredicate<GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl>(p, GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
