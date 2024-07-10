using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeAddFieldDefinitionActionQueryBuilderDsl
    {
        public TypeAddFieldDefinitionActionQueryBuilderDsl()
        {
        }

        public static TypeAddFieldDefinitionActionQueryBuilderDsl Of()
        {
            return new TypeAddFieldDefinitionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeAddFieldDefinitionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeAddFieldDefinitionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeAddFieldDefinitionActionQueryBuilderDsl>(p, TypeAddFieldDefinitionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeAddFieldDefinitionActionQueryBuilderDsl> FieldDefinition(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeAddFieldDefinitionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fieldDefinition"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl.Of())),
                TypeAddFieldDefinitionActionQueryBuilderDsl.Of);
        }


    }
}
