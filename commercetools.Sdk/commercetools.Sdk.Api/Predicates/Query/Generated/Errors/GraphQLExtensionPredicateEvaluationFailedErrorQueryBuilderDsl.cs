using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl
    {
        public GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>(p, GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl> ErrorByExtension(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorByExtensionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorByExtensionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errorByExtension"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorByExtensionQueryBuilderDsl.Of())),
                GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of);
        }


    }
}
