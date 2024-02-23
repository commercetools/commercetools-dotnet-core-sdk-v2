// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MaxCartDiscountsReachedErrorQueryBuilderDsl
    {
        public MaxCartDiscountsReachedErrorQueryBuilderDsl()
        {
        }

        public static MaxCartDiscountsReachedErrorQueryBuilderDsl Of()
        {
            return new MaxCartDiscountsReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MaxCartDiscountsReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MaxCartDiscountsReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MaxCartDiscountsReachedErrorQueryBuilderDsl>(p, MaxCartDiscountsReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MaxCartDiscountsReachedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MaxCartDiscountsReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MaxCartDiscountsReachedErrorQueryBuilderDsl>(p, MaxCartDiscountsReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
