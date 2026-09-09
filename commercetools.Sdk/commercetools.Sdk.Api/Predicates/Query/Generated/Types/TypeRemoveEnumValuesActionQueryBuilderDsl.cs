// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeRemoveEnumValuesActionQueryBuilderDsl
    {
        public TypeRemoveEnumValuesActionQueryBuilderDsl()
        {
        }

        public static TypeRemoveEnumValuesActionQueryBuilderDsl Of()
        {
            return new TypeRemoveEnumValuesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeRemoveEnumValuesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeRemoveEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeRemoveEnumValuesActionQueryBuilderDsl>(p, TypeRemoveEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeRemoveEnumValuesActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeRemoveEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeRemoveEnumValuesActionQueryBuilderDsl>(p, TypeRemoveEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<TypeRemoveEnumValuesActionQueryBuilderDsl, string> Keys()
        {
            return new ComparableCollectionPredicateBuilder<TypeRemoveEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("keys")),
            p => new CombinationQueryPredicate<TypeRemoveEnumValuesActionQueryBuilderDsl>(p, TypeRemoveEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
