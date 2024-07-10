using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryResourceIdentifierQueryBuilderDsl
    {
        public InventoryEntryResourceIdentifierQueryBuilderDsl()
        {
        }

        public static InventoryEntryResourceIdentifierQueryBuilderDsl Of()
        {
            return new InventoryEntryResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<InventoryEntryResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<InventoryEntryResourceIdentifierQueryBuilderDsl>(p, InventoryEntryResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryResourceIdentifierQueryBuilderDsl>(p, InventoryEntryResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<InventoryEntryResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<InventoryEntryResourceIdentifierQueryBuilderDsl>(p, InventoryEntryResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
