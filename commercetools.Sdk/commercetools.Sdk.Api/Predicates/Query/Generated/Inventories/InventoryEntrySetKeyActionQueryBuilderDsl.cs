using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetKeyActionQueryBuilderDsl
    {
        public InventoryEntrySetKeyActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetKeyActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetKeyActionQueryBuilderDsl>(p, InventoryEntrySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<InventoryEntrySetKeyActionQueryBuilderDsl>(p, InventoryEntrySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
