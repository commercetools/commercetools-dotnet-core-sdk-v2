// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetCustomFieldActionQueryBuilderDsl
    {
        public DiscountCodeSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetCustomFieldActionQueryBuilderDsl>(p, DiscountCodeSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<DiscountCodeSetCustomFieldActionQueryBuilderDsl>(p, DiscountCodeSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<DiscountCodeSetCustomFieldActionQueryBuilderDsl>(p, DiscountCodeSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
