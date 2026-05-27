using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionSetAdditionalContextActionQueryBuilderDsl
    {
        public ExtensionSetAdditionalContextActionQueryBuilderDsl()
        {
        }

        public static ExtensionSetAdditionalContextActionQueryBuilderDsl Of()
        {
            return new ExtensionSetAdditionalContextActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionSetAdditionalContextActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionSetAdditionalContextActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionSetAdditionalContextActionQueryBuilderDsl>(p, ExtensionSetAdditionalContextActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionSetAdditionalContextActionQueryBuilderDsl> AdditionalContext(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionAdditionalContextDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionAdditionalContextDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionSetAdditionalContextActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("additionalContext"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionAdditionalContextDraftQueryBuilderDsl.Of())),
                ExtensionSetAdditionalContextActionQueryBuilderDsl.Of);
        }


    }
}
