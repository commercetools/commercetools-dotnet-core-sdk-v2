using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantBulkUpdateQueryBuilderDsl
    {
        public VariantBulkUpdateQueryBuilderDsl()
        {
        }

        public static VariantBulkUpdateQueryBuilderDsl Of()
        {
            return new VariantBulkUpdateQueryBuilderDsl();
        }

        public CombinationQueryPredicate<VariantBulkUpdateQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantBulkUpdateItemQueryBuilderDsl.Of())),
                VariantBulkUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantBulkUpdateQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<VariantBulkUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<VariantBulkUpdateQueryBuilderDsl>(p, VariantBulkUpdateQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantBulkUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantBulkUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantUpdateActionQueryBuilderDsl.Of())),
                VariantBulkUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantBulkUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<VariantBulkUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<VariantBulkUpdateQueryBuilderDsl>(p, VariantBulkUpdateQueryBuilderDsl.Of));
        }

    }
}
