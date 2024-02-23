// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldBooleanTypeQueryBuilderDsl
    {
        public CustomFieldBooleanTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldBooleanTypeQueryBuilderDsl Of()
        {
            return new CustomFieldBooleanTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldBooleanTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldBooleanTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldBooleanTypeQueryBuilderDsl>(p, CustomFieldBooleanTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
