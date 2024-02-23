// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldNumberTypeQueryBuilderDsl
    {
        public CustomFieldNumberTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldNumberTypeQueryBuilderDsl Of()
        {
            return new CustomFieldNumberTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldNumberTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldNumberTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldNumberTypeQueryBuilderDsl>(p, CustomFieldNumberTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
