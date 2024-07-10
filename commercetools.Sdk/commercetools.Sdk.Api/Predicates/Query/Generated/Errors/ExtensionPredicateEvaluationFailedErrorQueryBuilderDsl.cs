using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl
    {
        public ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl()
        {
        }

        public static ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl Of()
        {
            return new ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>(p, ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>(p, ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl> ErrorByExtension(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorByExtensionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorByExtensionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errorByExtension"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorByExtensionQueryBuilderDsl.Of())),
                ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of);
        }


    }
}
