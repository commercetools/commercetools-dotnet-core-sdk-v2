// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionAdditionalContextDraftQueryBuilderDsl
    {
        public ExtensionAdditionalContextDraftQueryBuilderDsl()
        {
        }

        public static ExtensionAdditionalContextDraftQueryBuilderDsl Of()
        {
            return new ExtensionAdditionalContextDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionAdditionalContextDraftQueryBuilderDsl, bool> IncludeOldResource()
        {
            return new ComparisonPredicateBuilder<ExtensionAdditionalContextDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includeOldResource")),
            p => new CombinationQueryPredicate<ExtensionAdditionalContextDraftQueryBuilderDsl>(p, ExtensionAdditionalContextDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
