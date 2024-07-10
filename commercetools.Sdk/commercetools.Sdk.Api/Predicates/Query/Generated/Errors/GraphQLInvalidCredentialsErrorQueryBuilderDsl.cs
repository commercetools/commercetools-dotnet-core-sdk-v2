using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidCredentialsErrorQueryBuilderDsl
    {
        public GraphQLInvalidCredentialsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidCredentialsErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidCredentialsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidCredentialsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidCredentialsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidCredentialsErrorQueryBuilderDsl>(p, GraphQLInvalidCredentialsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
