using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupCreatedMessagePayloadQueryBuilderDsl
    {
        public DiscountGroupCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountGroupCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountGroupCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupCreatedMessagePayloadQueryBuilderDsl>(p, DiscountGroupCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupCreatedMessagePayloadQueryBuilderDsl> DiscountGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl.Of())),
                DiscountGroupCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
