// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetSkuActionQueryBuilderDsl
    {
        public VariantSetSkuActionQueryBuilderDsl()
        {
        }

        public static VariantSetSkuActionQueryBuilderDsl Of()
        {
            return new VariantSetSkuActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetSkuActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetSkuActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetSkuActionQueryBuilderDsl>(p, VariantSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetSkuActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantSetSkuActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantSetSkuActionQueryBuilderDsl>(p, VariantSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetSkuActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetSkuActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetSkuActionQueryBuilderDsl>(p, VariantSetSkuActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
