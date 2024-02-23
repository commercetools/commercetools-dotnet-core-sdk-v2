using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLEditPreviewFailedErrorQueryBuilderDsl
    {
        public GraphQLEditPreviewFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLEditPreviewFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLEditPreviewFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLEditPreviewFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLEditPreviewFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLEditPreviewFailedErrorQueryBuilderDsl>(p, GraphQLEditPreviewFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLEditPreviewFailedErrorQueryBuilderDsl> Result(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLEditPreviewFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("result"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl.Of())),
                GraphQLEditPreviewFailedErrorQueryBuilderDsl.Of);
        }


    }
}
