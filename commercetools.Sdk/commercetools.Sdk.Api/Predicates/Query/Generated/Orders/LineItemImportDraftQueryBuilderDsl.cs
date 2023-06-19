using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class LineItemImportDraftQueryBuilderDsl
    {
        public LineItemImportDraftQueryBuilderDsl()
        {
        }

        public static LineItemImportDraftQueryBuilderDsl Of()
        {
            return new LineItemImportDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemImportDraftQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<LineItemImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(p, LineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ProductVariantImportDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ProductVariantImportDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ProductVariantImportDraftQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemImportDraftQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemImportDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(p, LineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<LineItemImportDraftQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<LineItemImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(p, LineItemImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemImportDraftQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<LineItemImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(p, LineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                LineItemImportDraftQueryBuilderDsl.Of);
        }


    }
}
