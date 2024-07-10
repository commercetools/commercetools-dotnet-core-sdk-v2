using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLProductAssignmentMissingErrorQueryBuilderDsl
    {
        public GraphQLProductAssignmentMissingErrorQueryBuilderDsl()
        {
        }

        public static GraphQLProductAssignmentMissingErrorQueryBuilderDsl Of()
        {
            return new GraphQLProductAssignmentMissingErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLProductAssignmentMissingErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLProductAssignmentMissingErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLProductAssignmentMissingErrorQueryBuilderDsl>(p, GraphQLProductAssignmentMissingErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLProductAssignmentMissingErrorQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLProductAssignmentMissingErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                GraphQLProductAssignmentMissingErrorQueryBuilderDsl.Of);
        }


    }
}
