using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl
    {
        public OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl>(p, OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
