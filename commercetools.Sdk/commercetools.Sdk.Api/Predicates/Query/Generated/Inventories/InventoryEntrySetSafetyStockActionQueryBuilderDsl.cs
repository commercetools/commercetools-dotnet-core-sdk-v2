// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetSafetyStockActionQueryBuilderDsl
    {
        public InventoryEntrySetSafetyStockActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetSafetyStockActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetSafetyStockActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetSafetyStockActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetSafetyStockActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetSafetyStockActionQueryBuilderDsl>(p, InventoryEntrySetSafetyStockActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetSafetyStockActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetSafetyStockActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<InventoryEntrySetSafetyStockActionQueryBuilderDsl>(p, InventoryEntrySetSafetyStockActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
