// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeRemoveFieldDefinitionActionQueryBuilderDsl
    {
        public TypeRemoveFieldDefinitionActionQueryBuilderDsl()
        {
        }

        public static TypeRemoveFieldDefinitionActionQueryBuilderDsl Of()
        {
            return new TypeRemoveFieldDefinitionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeRemoveFieldDefinitionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeRemoveFieldDefinitionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeRemoveFieldDefinitionActionQueryBuilderDsl>(p, TypeRemoveFieldDefinitionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeRemoveFieldDefinitionActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeRemoveFieldDefinitionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeRemoveFieldDefinitionActionQueryBuilderDsl>(p, TypeRemoveFieldDefinitionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
