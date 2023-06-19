// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeInputHintActionQueryBuilderDsl
    {
        public TypeChangeInputHintActionQueryBuilderDsl()
        {
        }

        public static TypeChangeInputHintActionQueryBuilderDsl Of()
        {
            return new TypeChangeInputHintActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeInputHintActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeInputHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeInputHintActionQueryBuilderDsl>(p, TypeChangeInputHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeInputHintActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeChangeInputHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeChangeInputHintActionQueryBuilderDsl>(p, TypeChangeInputHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeInputHintActionQueryBuilderDsl, string> InputHint()
        {
            return new ComparisonPredicateBuilder<TypeChangeInputHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inputHint")),
            p => new CombinationQueryPredicate<TypeChangeInputHintActionQueryBuilderDsl>(p, TypeChangeInputHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
