using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryCreatedMessagePayloadQueryBuilderDsl
    {
        public InventoryEntryCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntryCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntryCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessagePayloadQueryBuilderDsl>(p, InventoryEntryCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryCreatedMessagePayloadQueryBuilderDsl> InventoryEntry(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inventoryEntry"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl.Of())),
                InventoryEntryCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
