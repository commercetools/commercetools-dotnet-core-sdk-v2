using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueGiftLineItemDraftQueryBuilderDsl
    {
        public CartDiscountValueGiftLineItemDraftQueryBuilderDsl()
        {
        }

        public static CartDiscountValueGiftLineItemDraftQueryBuilderDsl Of()
        {
            return new CartDiscountValueGiftLineItemDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueGiftLineItemDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueGiftLineItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl>(p, CartDiscountValueGiftLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountValueGiftLineItemDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountValueGiftLineItemDraftQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueGiftLineItemDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl>(p, CartDiscountValueGiftLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountValueGiftLineItemDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueGiftLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountValueGiftLineItemDraftQueryBuilderDsl.Of);
        }


    }
}
