// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MaxDiscountGroupsReachedErrorQueryBuilderDsl
    {
        public MaxDiscountGroupsReachedErrorQueryBuilderDsl()
        {
        }

        public static MaxDiscountGroupsReachedErrorQueryBuilderDsl Of()
        {
            return new MaxDiscountGroupsReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MaxDiscountGroupsReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MaxDiscountGroupsReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MaxDiscountGroupsReachedErrorQueryBuilderDsl>(p, MaxDiscountGroupsReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MaxDiscountGroupsReachedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MaxDiscountGroupsReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MaxDiscountGroupsReachedErrorQueryBuilderDsl>(p, MaxDiscountGroupsReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
