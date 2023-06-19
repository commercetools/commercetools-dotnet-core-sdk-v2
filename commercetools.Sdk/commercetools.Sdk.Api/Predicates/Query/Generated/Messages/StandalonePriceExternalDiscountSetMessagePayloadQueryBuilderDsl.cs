using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl.Of())),
                StandalonePriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
