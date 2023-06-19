// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldEnumValueQueryBuilderDsl
    {
        public CustomFieldEnumValueQueryBuilderDsl()
        {
        }

        public static CustomFieldEnumValueQueryBuilderDsl Of()
        {
            return new CustomFieldEnumValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldEnumValueQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomFieldEnumValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomFieldEnumValueQueryBuilderDsl>(p, CustomFieldEnumValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomFieldEnumValueQueryBuilderDsl, string> Label()
        {
            return new ComparisonPredicateBuilder<CustomFieldEnumValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("label")),
            p => new CombinationQueryPredicate<CustomFieldEnumValueQueryBuilderDsl>(p, CustomFieldEnumValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
