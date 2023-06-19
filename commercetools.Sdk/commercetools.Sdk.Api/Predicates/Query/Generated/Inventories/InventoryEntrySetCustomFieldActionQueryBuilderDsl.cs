// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetCustomFieldActionQueryBuilderDsl
    {
        public InventoryEntrySetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetCustomFieldActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetCustomFieldActionQueryBuilderDsl>(p, InventoryEntrySetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<InventoryEntrySetCustomFieldActionQueryBuilderDsl>(p, InventoryEntrySetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<InventoryEntrySetCustomFieldActionQueryBuilderDsl>(p, InventoryEntrySetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
