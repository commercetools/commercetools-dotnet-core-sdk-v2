// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldLocalizedStringTypeQueryBuilderDsl
    {
        public CustomFieldLocalizedStringTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldLocalizedStringTypeQueryBuilderDsl Of()
        {
            return new CustomFieldLocalizedStringTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldLocalizedStringTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldLocalizedStringTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldLocalizedStringTypeQueryBuilderDsl>(p, CustomFieldLocalizedStringTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
