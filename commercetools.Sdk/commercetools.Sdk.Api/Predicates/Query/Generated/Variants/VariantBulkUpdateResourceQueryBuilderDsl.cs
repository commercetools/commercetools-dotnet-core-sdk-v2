// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateResourceQueryBuilderDsl
    {
        public VariantBulkUpdateResourceQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateResourceQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateResourceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantBulkUpdateResourceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResourceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResourceQueryBuilderDsl>(p, VariantBulkUpdateResourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateResourceQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResourceQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResourceQueryBuilderDsl>(p, VariantBulkUpdateResourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
