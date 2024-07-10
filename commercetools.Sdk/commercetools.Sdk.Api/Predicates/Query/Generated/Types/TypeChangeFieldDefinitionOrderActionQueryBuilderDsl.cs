using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeFieldDefinitionOrderActionQueryBuilderDsl
    {
        public TypeChangeFieldDefinitionOrderActionQueryBuilderDsl()
        {
        }

        public static TypeChangeFieldDefinitionOrderActionQueryBuilderDsl Of()
        {
            return new TypeChangeFieldDefinitionOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeFieldDefinitionOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeFieldDefinitionOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeFieldDefinitionOrderActionQueryBuilderDsl>(p, TypeChangeFieldDefinitionOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<TypeChangeFieldDefinitionOrderActionQueryBuilderDsl, string> FieldNames()
        {
            return new ComparableCollectionPredicateBuilder<TypeChangeFieldDefinitionOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldNames")),
            p => new CombinationQueryPredicate<TypeChangeFieldDefinitionOrderActionQueryBuilderDsl>(p, TypeChangeFieldDefinitionOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
