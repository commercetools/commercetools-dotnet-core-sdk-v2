using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountCodeCreatedMessagePayloadQueryBuilderDsl
    {
        public DiscountCodeCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountCodeCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountCodeCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessagePayloadQueryBuilderDsl>(p, DiscountCodeCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeCreatedMessagePayloadQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl.Of())),
                DiscountCodeCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
