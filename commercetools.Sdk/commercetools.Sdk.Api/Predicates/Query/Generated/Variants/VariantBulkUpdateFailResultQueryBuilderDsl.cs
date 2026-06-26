using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateFailResultQueryBuilderDsl
    {
        public VariantBulkUpdateFailResultQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateFailResultQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateFailResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantBulkUpdateFailResultQueryBuilderDsl>(p, VariantBulkUpdateFailResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantBulkUpdateFailResultQueryBuilderDsl>(p, VariantBulkUpdateFailResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<VariantBulkUpdateFailResultQueryBuilderDsl>(p, VariantBulkUpdateFailResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantBulkUpdateFailResultQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateFailResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                VariantBulkUpdateFailResultQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<VariantBulkUpdateFailResultQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<VariantBulkUpdateFailResultQueryBuilderDsl>(p, VariantBulkUpdateFailResultQueryBuilderDsl.Of));
        }

    }
}
