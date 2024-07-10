using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryDraftQueryBuilderDsl
    {
        public InventoryEntryDraftQueryBuilderDsl()
        {
        }

        public static InventoryEntryDraftQueryBuilderDsl Of()
        {
            return new InventoryEntryDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(p, InventoryEntryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(p, InventoryEntryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                InventoryEntryDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, long> QuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(p, InventoryEntryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, long> RestockableInDays()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("restockableInDays")),
            p => new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(p, InventoryEntryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, DateTime> ExpectedDelivery()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expectedDelivery")),
            p => new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(p, InventoryEntryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                InventoryEntryDraftQueryBuilderDsl.Of);
        }


    }
}
