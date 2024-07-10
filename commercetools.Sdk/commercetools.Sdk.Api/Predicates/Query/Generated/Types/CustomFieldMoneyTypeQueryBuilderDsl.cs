// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldMoneyTypeQueryBuilderDsl
    {
        public CustomFieldMoneyTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldMoneyTypeQueryBuilderDsl Of()
        {
            return new CustomFieldMoneyTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldMoneyTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldMoneyTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldMoneyTypeQueryBuilderDsl>(p, CustomFieldMoneyTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
