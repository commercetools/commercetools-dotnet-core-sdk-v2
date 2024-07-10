// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountCodeDeletedMessagePayloadQueryBuilderDsl
    {
        public DiscountCodeDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountCodeDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountCodeDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountCodeDeletedMessagePayloadQueryBuilderDsl>(p, DiscountCodeDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
