// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantPublishActionQueryBuilderDsl
    {
        public VariantPublishActionQueryBuilderDsl()
        {
        }

        public static VariantPublishActionQueryBuilderDsl Of()
        {
            return new VariantPublishActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantPublishActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantPublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantPublishActionQueryBuilderDsl>(p, VariantPublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
