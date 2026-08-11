using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateResponseQueryBuilderDsl
    {
        public VariantBulkUpdateResponseQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateResponseQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantBulkUpdateResponseQueryBuilderDsl, long> SuccessCount()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("successCount")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResponseQueryBuilderDsl>(p, VariantBulkUpdateResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateResponseQueryBuilderDsl, long> FailureCount()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failureCount")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResponseQueryBuilderDsl>(p, VariantBulkUpdateResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantBulkUpdateResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateResultQueryBuilderDsl.Of())),
                VariantBulkUpdateResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantBulkUpdateResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<VariantBulkUpdateResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<VariantBulkUpdateResponseQueryBuilderDsl>(p, VariantBulkUpdateResponseQueryBuilderDsl.Of));
        }

    }
}
