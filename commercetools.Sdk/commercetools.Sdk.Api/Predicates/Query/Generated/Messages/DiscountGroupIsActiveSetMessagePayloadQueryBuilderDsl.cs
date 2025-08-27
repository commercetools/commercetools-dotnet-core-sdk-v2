// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl
    {
        public DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl, bool> OldIsActive()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldIsActive")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
