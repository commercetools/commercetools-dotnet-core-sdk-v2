using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class FieldDefinitionQueryBuilderDsl
    {
        public FieldDefinitionQueryBuilderDsl()
        {
        }

        public static FieldDefinitionQueryBuilderDsl Of()
        {
            return new FieldDefinitionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldTypeQueryBuilderDsl.Of())),
                FieldDefinitionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<FieldDefinitionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<FieldDefinitionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl>(p, FieldDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                FieldDefinitionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<FieldDefinitionQueryBuilderDsl, bool> Required()
        {
            return new ComparisonPredicateBuilder<FieldDefinitionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("required")),
            p => new CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl>(p, FieldDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FieldDefinitionQueryBuilderDsl, string> InputHint()
        {
            return new ComparisonPredicateBuilder<FieldDefinitionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inputHint")),
            p => new CombinationQueryPredicate<FieldDefinitionQueryBuilderDsl>(p, FieldDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
