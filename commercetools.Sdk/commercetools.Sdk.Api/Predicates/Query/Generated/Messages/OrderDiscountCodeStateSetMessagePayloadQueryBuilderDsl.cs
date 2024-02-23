using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl
    {
        public OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl>(p, OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl>(p, OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, string> OldState()
        {
            return new ComparisonPredicateBuilder<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldState")),
            p => new CombinationQueryPredicate<OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl>(p, OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
