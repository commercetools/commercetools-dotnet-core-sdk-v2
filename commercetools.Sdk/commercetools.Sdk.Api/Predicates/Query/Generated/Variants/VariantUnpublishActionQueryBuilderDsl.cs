// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantUnpublishActionQueryBuilderDsl
    {
        public VariantUnpublishActionQueryBuilderDsl()
        {
        }

        public static VariantUnpublishActionQueryBuilderDsl Of()
        {
            return new VariantUnpublishActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantUnpublishActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantUnpublishActionQueryBuilderDsl>(p, VariantUnpublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
