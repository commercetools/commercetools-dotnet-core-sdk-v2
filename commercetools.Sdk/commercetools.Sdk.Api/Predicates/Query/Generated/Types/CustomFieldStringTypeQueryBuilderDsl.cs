// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldStringTypeQueryBuilderDsl
    {
        public CustomFieldStringTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldStringTypeQueryBuilderDsl Of()
        {
            return new CustomFieldStringTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldStringTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldStringTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldStringTypeQueryBuilderDsl>(p, CustomFieldStringTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
