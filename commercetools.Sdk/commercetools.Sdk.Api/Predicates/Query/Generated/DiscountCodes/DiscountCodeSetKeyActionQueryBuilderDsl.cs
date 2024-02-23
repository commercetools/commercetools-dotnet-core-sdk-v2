// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetKeyActionQueryBuilderDsl
    {
        public DiscountCodeSetKeyActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetKeyActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetKeyActionQueryBuilderDsl>(p, DiscountCodeSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountCodeSetKeyActionQueryBuilderDsl>(p, DiscountCodeSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
