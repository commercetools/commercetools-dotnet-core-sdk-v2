// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupDeletedMessagePayloadQueryBuilderDsl
    {
        public DiscountGroupDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountGroupDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountGroupDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupDeletedMessagePayloadQueryBuilderDsl>(p, DiscountGroupDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
