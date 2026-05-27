// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionAdditionalContextQueryBuilderDsl
    {
        public ExtensionAdditionalContextQueryBuilderDsl()
        {
        }

        public static ExtensionAdditionalContextQueryBuilderDsl Of()
        {
            return new ExtensionAdditionalContextQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionAdditionalContextQueryBuilderDsl, bool> IncludeOldResource()
        {
            return new ComparisonPredicateBuilder<ExtensionAdditionalContextQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includeOldResource")),
            p => new CombinationQueryPredicate<ExtensionAdditionalContextQueryBuilderDsl>(p, ExtensionAdditionalContextQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
