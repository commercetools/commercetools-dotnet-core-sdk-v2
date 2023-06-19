using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.GraphQl
{

    public partial class GraphQLRequestQueryBuilderDsl
    {
        public GraphQLRequestQueryBuilderDsl()
        {
        }

        public static GraphQLRequestQueryBuilderDsl Of()
        {
            return new GraphQLRequestQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLRequestQueryBuilderDsl, string> Query()
        {
            return new ComparisonPredicateBuilder<GraphQLRequestQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("query")),
            p => new CombinationQueryPredicate<GraphQLRequestQueryBuilderDsl>(p, GraphQLRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLRequestQueryBuilderDsl, string> OperationName()
        {
            return new ComparisonPredicateBuilder<GraphQLRequestQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("operationName")),
            p => new CombinationQueryPredicate<GraphQLRequestQueryBuilderDsl>(p, GraphQLRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLRequestQueryBuilderDsl> Variables(
            Func<commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLVariablesMapQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLVariablesMapQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variables"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLVariablesMapQueryBuilderDsl.Of())),
                GraphQLRequestQueryBuilderDsl.Of);
        }


    }
}
