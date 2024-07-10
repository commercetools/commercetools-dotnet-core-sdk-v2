// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class PriceChangedErrorQueryBuilderDsl
    {
        public PriceChangedErrorQueryBuilderDsl()
        {
        }

        public static PriceChangedErrorQueryBuilderDsl Of()
        {
            return new PriceChangedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PriceChangedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<PriceChangedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<PriceChangedErrorQueryBuilderDsl>(p, PriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PriceChangedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<PriceChangedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<PriceChangedErrorQueryBuilderDsl>(p, PriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<PriceChangedErrorQueryBuilderDsl, string> LineItems()
        {
            return new ComparableCollectionPredicateBuilder<PriceChangedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
            p => new CombinationQueryPredicate<PriceChangedErrorQueryBuilderDsl>(p, PriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PriceChangedErrorQueryBuilderDsl, bool> Shipping()
        {
            return new ComparisonPredicateBuilder<PriceChangedErrorQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipping")),
            p => new CombinationQueryPredicate<PriceChangedErrorQueryBuilderDsl>(p, PriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
