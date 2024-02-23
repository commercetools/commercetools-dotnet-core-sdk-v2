// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class NoMatchingProductDiscountFoundErrorQueryBuilderDsl
    {
        public NoMatchingProductDiscountFoundErrorQueryBuilderDsl()
        {
        }

        public static NoMatchingProductDiscountFoundErrorQueryBuilderDsl Of()
        {
            return new NoMatchingProductDiscountFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<NoMatchingProductDiscountFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<NoMatchingProductDiscountFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<NoMatchingProductDiscountFoundErrorQueryBuilderDsl>(p, NoMatchingProductDiscountFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<NoMatchingProductDiscountFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<NoMatchingProductDiscountFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<NoMatchingProductDiscountFoundErrorQueryBuilderDsl>(p, NoMatchingProductDiscountFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
