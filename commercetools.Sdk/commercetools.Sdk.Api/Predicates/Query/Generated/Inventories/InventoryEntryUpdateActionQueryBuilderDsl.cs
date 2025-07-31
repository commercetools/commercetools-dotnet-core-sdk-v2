using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryUpdateActionQueryBuilderDsl
    {
        public InventoryEntryUpdateActionQueryBuilderDsl()
        {
        }

        public static InventoryEntryUpdateActionQueryBuilderDsl Of()
        {
            return new InventoryEntryUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntryUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(p, InventoryEntryUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsAddQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryAddQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryAddQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryAddQuantityActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsChangeQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryChangeQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryChangeQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryChangeQuantityActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsRemoveQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryRemoveQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryRemoveQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryRemoveQuantityActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetCustomFieldActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetCustomTypeActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetExpectedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetInventoryLimits(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetInventoryLimitsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetInventoryLimitsActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetKeyActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetRestockableInDays(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetRestockableInDaysActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetRestockableInDaysActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetRestockableInDaysActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl> AsSetSupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetSupplyChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetSupplyChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntrySetSupplyChannelActionQueryBuilderDsl.Of()),
                InventoryEntryUpdateActionQueryBuilderDsl.Of);
        }
    }
}
