// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetRestockableInDaysActionQueryBuilderDsl
    {
        public InventoryEntrySetRestockableInDaysActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetRestockableInDaysActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetRestockableInDaysActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetRestockableInDaysActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetRestockableInDaysActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetRestockableInDaysActionQueryBuilderDsl>(p, InventoryEntrySetRestockableInDaysActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetRestockableInDaysActionQueryBuilderDsl, long> RestockableInDays()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetRestockableInDaysActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("restockableInDays")),
            p => new CombinationQueryPredicate<InventoryEntrySetRestockableInDaysActionQueryBuilderDsl>(p, InventoryEntrySetRestockableInDaysActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
