using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSyntaxErrorErrorQueryBuilderDsl
    {
        public GraphQLSyntaxErrorErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSyntaxErrorErrorQueryBuilderDsl Of()
        {
            return new GraphQLSyntaxErrorErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSyntaxErrorErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSyntaxErrorErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSyntaxErrorErrorQueryBuilderDsl>(p, GraphQLSyntaxErrorErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
