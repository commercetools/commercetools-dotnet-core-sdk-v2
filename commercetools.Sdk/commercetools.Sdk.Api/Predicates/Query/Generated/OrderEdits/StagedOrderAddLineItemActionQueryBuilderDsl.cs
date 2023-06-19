using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddLineItemActionQueryBuilderDsl
    {
        public StagedOrderAddLineItemActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddLineItemActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddLineItemActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(p, StagedOrderAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> ExternalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> ExternalTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                StagedOrderAddLineItemActionQueryBuilderDsl.Of);
        }


    }
}
