// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl
    {
        public TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl()
        {
        }

        public static TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl Of()
        {
            return new TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl>(p, TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl>(p, TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl, string> Keys()
        {
            return new ComparableCollectionPredicateBuilder<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("keys")),
            p => new CombinationQueryPredicate<TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl>(p, TypeRemoveLocalizedEnumValuesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
