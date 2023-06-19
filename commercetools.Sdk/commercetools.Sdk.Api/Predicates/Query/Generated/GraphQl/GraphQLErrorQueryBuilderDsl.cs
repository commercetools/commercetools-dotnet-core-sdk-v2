using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.GraphQl
{

    public partial class GraphQLErrorQueryBuilderDsl
    {
        public GraphQLErrorQueryBuilderDsl()
        {
        }

        public static GraphQLErrorQueryBuilderDsl Of()
        {
            return new GraphQLErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<GraphQLErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl>(p, GraphQLErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl> Locations(
            Func<commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLErrorLocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLErrorLocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("locations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.GraphQl.GraphQLErrorLocationQueryBuilderDsl.Of())),
                GraphQLErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<GraphQLErrorQueryBuilderDsl> Locations()
        {
            return new CollectionPredicateBuilder<GraphQLErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locations")),
                    p => new CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl>(p, GraphQLErrorQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<GraphQLErrorQueryBuilderDsl, string> Path()
        {
            return new ComparisonPredicateBuilder<GraphQLErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("path")),
            p => new CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl>(p, GraphQLErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl> Extensions(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("extensions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLErrorObjectQueryBuilderDsl.Of())),
                GraphQLErrorQueryBuilderDsl.Of);
        }


    }
}
