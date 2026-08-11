using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateSuccessResultQueryBuilderDsl
    {
        public VariantBulkUpdateSuccessResultQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateSuccessResultQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateSuccessResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantBulkUpdateSuccessResultQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateSuccessResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantBulkUpdateSuccessResultQueryBuilderDsl>(p, VariantBulkUpdateSuccessResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateSuccessResultQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateSuccessResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantBulkUpdateSuccessResultQueryBuilderDsl>(p, VariantBulkUpdateSuccessResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateSuccessResultQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateSuccessResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<VariantBulkUpdateSuccessResultQueryBuilderDsl>(p, VariantBulkUpdateSuccessResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantBulkUpdateSuccessResultQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateResourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateResourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateSuccessResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateResourceQueryBuilderDsl.Of())),
                VariantBulkUpdateSuccessResultQueryBuilderDsl.Of);
        }


    }
}
