// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateItemQueryBuilderDsl
    {
        public VariantBulkUpdateItemQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateItemQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantBulkUpdateItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantBulkUpdateItemQueryBuilderDsl>(p, VariantBulkUpdateItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantBulkUpdateItemQueryBuilderDsl>(p, VariantBulkUpdateItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateItemQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantBulkUpdateItemQueryBuilderDsl>(p, VariantBulkUpdateItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
