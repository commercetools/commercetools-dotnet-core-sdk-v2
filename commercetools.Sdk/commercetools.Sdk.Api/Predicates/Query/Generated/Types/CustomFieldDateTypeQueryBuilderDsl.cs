// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldDateTypeQueryBuilderDsl
    {
        public CustomFieldDateTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldDateTypeQueryBuilderDsl Of()
        {
            return new CustomFieldDateTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldDateTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldDateTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldDateTypeQueryBuilderDsl>(p, CustomFieldDateTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
