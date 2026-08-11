using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateResultQueryBuilderDsl
    {
        public VariantBulkUpdateResultQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateResultQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantBulkUpdateResultQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl>(p, VariantBulkUpdateResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateResultQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl>(p, VariantBulkUpdateResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateResultQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl>(p, VariantBulkUpdateResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl> AsFail(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateFailResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateFailResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateFailResultQueryBuilderDsl.Of()),
                VariantBulkUpdateResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl> AsSuccess(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateSuccessResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateSuccessResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateSuccessResultQueryBuilderDsl.Of()),
                VariantBulkUpdateResultQueryBuilderDsl.Of);
        }
    }
}
