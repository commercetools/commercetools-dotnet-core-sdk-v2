using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueGiftLineItemQueryBuilderDsl
    {
        public CartDiscountValueGiftLineItemQueryBuilderDsl()
        {
        }

        public static CartDiscountValueGiftLineItemQueryBuilderDsl Of()
        {
            return new CartDiscountValueGiftLineItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueGiftLineItemQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueGiftLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl>(p, CartDiscountValueGiftLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                CartDiscountValueGiftLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountValueGiftLineItemQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueGiftLineItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl>(p, CartDiscountValueGiftLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                CartDiscountValueGiftLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueGiftLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                CartDiscountValueGiftLineItemQueryBuilderDsl.Of);
        }


    }
}
