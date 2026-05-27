// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryStockLevelsQueryBuilderDsl
    {
        public InventoryEntryStockLevelsQueryBuilderDsl()
        {
        }

        public static InventoryEntryStockLevelsQueryBuilderDsl Of()
        {
            return new InventoryEntryStockLevelsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryStockLevelsQueryBuilderDsl, long> ReorderPoint()
        {
            return new ComparisonPredicateBuilder<InventoryEntryStockLevelsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reorderPoint")),
            p => new CombinationQueryPredicate<InventoryEntryStockLevelsQueryBuilderDsl>(p, InventoryEntryStockLevelsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryStockLevelsQueryBuilderDsl, long> SafetyStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryStockLevelsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("safetyStock")),
            p => new CombinationQueryPredicate<InventoryEntryStockLevelsQueryBuilderDsl>(p, InventoryEntryStockLevelsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
