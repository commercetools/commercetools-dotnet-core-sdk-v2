// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl
    {
        public DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl, string> OldSortOrder()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldSortOrder")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
