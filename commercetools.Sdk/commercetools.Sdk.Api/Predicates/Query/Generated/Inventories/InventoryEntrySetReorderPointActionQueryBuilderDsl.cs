// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetReorderPointActionQueryBuilderDsl
    {
        public InventoryEntrySetReorderPointActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetReorderPointActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetReorderPointActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetReorderPointActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetReorderPointActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetReorderPointActionQueryBuilderDsl>(p, InventoryEntrySetReorderPointActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetReorderPointActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetReorderPointActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<InventoryEntrySetReorderPointActionQueryBuilderDsl>(p, InventoryEntrySetReorderPointActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
