using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.GraphQl
{

    public partial class GraphQLResponseQueryBuilderDsl
    {
        public GraphQLResponseQueryBuilderDsl()
        {
        }

        public static GraphQLResponseQueryBuilderDsl Of()
        {
            return new GraphQLResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLResponseQueryBuilderDsl, string> Data()
        {
            return new ComparisonPredicateBuilder<GraphQLResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("data")),
            p => new CombinationQueryPredicate<GraphQLResponseQueryBuilderDsl>(p, GraphQLResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLResponseQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLErrorQueryBuilderDsl.Of())),
                GraphQLResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<GraphQLResponseQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<GraphQLResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<GraphQLResponseQueryBuilderDsl>(p, GraphQLResponseQueryBuilderDsl.Of));
        }

    }
}
