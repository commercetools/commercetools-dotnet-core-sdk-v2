using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidSubjectErrorQueryBuilderDsl
    {
        public GraphQLInvalidSubjectErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidSubjectErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidSubjectErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidSubjectErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidSubjectErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidSubjectErrorQueryBuilderDsl>(p, GraphQLInvalidSubjectErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
