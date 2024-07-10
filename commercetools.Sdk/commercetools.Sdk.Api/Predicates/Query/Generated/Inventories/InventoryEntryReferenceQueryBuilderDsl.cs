using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryReferenceQueryBuilderDsl
    {
        public InventoryEntryReferenceQueryBuilderDsl()
        {
        }

        public static InventoryEntryReferenceQueryBuilderDsl Of()
        {
            return new InventoryEntryReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<InventoryEntryReferenceQueryBuilderDsl>(p, InventoryEntryReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryReferenceQueryBuilderDsl>(p, InventoryEntryReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl.Of())),
                InventoryEntryReferenceQueryBuilderDsl.Of);
        }


    }
}
