using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.GraphQl
{

    public partial class GraphQLErrorLocationQueryBuilderDsl
    {
        public GraphQLErrorLocationQueryBuilderDsl()
        {
        }

        public static GraphQLErrorLocationQueryBuilderDsl Of()
        {
            return new GraphQLErrorLocationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLErrorLocationQueryBuilderDsl, long> Line()
        {
            return new ComparisonPredicateBuilder<GraphQLErrorLocationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("line")),
            p => new CombinationQueryPredicate<GraphQLErrorLocationQueryBuilderDsl>(p, GraphQLErrorLocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLErrorLocationQueryBuilderDsl, long> Column()
        {
            return new ComparisonPredicateBuilder<GraphQLErrorLocationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("column")),
            p => new CombinationQueryPredicate<GraphQLErrorLocationQueryBuilderDsl>(p, GraphQLErrorLocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
