// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldReferenceTypeQueryBuilderDsl
    {
        public CustomFieldReferenceTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldReferenceTypeQueryBuilderDsl Of()
        {
            return new CustomFieldReferenceTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldReferenceTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldReferenceTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldReferenceTypeQueryBuilderDsl>(p, CustomFieldReferenceTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomFieldReferenceTypeQueryBuilderDsl, string> ReferenceTypeId()
        {
            return new ComparisonPredicateBuilder<CustomFieldReferenceTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("referenceTypeId")),
            p => new CombinationQueryPredicate<CustomFieldReferenceTypeQueryBuilderDsl>(p, CustomFieldReferenceTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
