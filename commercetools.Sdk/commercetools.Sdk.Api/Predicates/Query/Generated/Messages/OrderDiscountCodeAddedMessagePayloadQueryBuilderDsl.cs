using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl
    {
        public OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl>(p, OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
